using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Alledrogo
{
    public partial class Koszyk : Form
    {
        static DateTime data_zam = DateTime.Now;
        readonly Random random = new Random();

        public Koszyk()
        {
            InitializeComponent();
        }
        private void button_usun_Click(object sender, EventArgs e)
        {
            if (DataGridView_koszyk.RowCount > 0)
            {
                foreach (DataGridViewRow item in DataGridView_koszyk.SelectedRows)
                {
                    Global_variable.Change_counter -= (int)item.Cells[2].Value;
                    DataGridView_koszyk.Rows.RemoveAt(item.Index);
                    Global_variable.Bill -= Convert.ToDouble(item.Cells[3].Value) * (int)item.Cells[2].Value;
                    textBox_do_zaplaty.Text = Global_variable.Bill.ToString("0.00" + " zl");
                }
            }
            else
            {
                MessageBox.Show("Brak obiektów do usunięcia", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button_Kup_Click(object sender, EventArgs e)
        {

            if (DataGridView_koszyk.RowCount == 0)
            {
                MessageBox.Show("Koszyk jest pusty", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Czy napewno chcesz dokonać zakupu ?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    Order_finish();
                }
            }
        }
        private List<string> Return_user_info()
        {
            string n_firmy, adres, miasto, k_pocztowy, kraj;
            string sql = "SELECT NazwaFirmy,Miasto,Adres,KodPocztowy,Kraj FROM Klienci WHERE IDklienta = @id";
            var command = new SqlCommand(sql, DBconnection.Connection());
            command.Parameters.AddWithValue("@id", Global_variable.IDklienta);
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                n_firmy = reader["NazwaFirmy"].ToString();
                miasto = reader["Miasto"].ToString();
                adres = reader["Adres"].ToString();
                k_pocztowy = reader["KodPocztowy"].ToString();
                kraj = reader["Kraj"].ToString();
                List<string> user_info = new List<string>() { n_firmy, miasto, adres, k_pocztowy, kraj };

                return user_info;
            }
        }
        private int Check_IDzam()
        {
            string sql = "SELECT MAX(IDzamówienia) FROM Zamówienia";
            var command = new SqlCommand(sql, DBconnection.Connection());
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                int id = Convert.ToInt32(reader[0]);
                return id + 1;
            }
        }
        private void Order_finish()
        {
            int id_zam = Check_IDzam();
            List<string> user_info = Return_user_info();
            string sql_z = "INSERT INTO ZNorthwind.dbo.Zamówienia(IDzamówienia,IDklienta,DataZamówienia,DataWysyłki,AdresOdbiorcy,NazwaOdbiorcy,MiastoOdbiorcy,KrajOdbiorcy,KodPocztowyOdbiorcy)" +
                    "          VALUES (@id_z,@id_k,@data_zam,@data_wys,@adres,@n_firmy,@miasto,@kraj,@k_pocztowy)";
            var command_z = new SqlCommand(sql_z, DBconnection.Connection());
            command_z.Parameters.AddWithValue("@id_z", id_zam);
            command_z.Parameters.AddWithValue("@id_k", Global_variable.IDklienta);
            command_z.Parameters.AddWithValue("@data_zam", data_zam);
            command_z.Parameters.AddWithValue("@data_wys", data_zam.AddHours(random.Next(4, 72)));
            command_z.Parameters.AddWithValue("@n_firmy", user_info.ElementAt(0).ToString());
            command_z.Parameters.AddWithValue("@miasto", user_info.ElementAt(1).ToString());
            command_z.Parameters.AddWithValue("@adres", user_info.ElementAt(2).ToString());
            command_z.Parameters.AddWithValue("@k_pocztowy", user_info.ElementAt(3).ToString());
            command_z.Parameters.AddWithValue("@kraj", user_info.ElementAt(4).ToString());
            command_z.ExecuteNonQuery();

            foreach (DataGridViewRow row in DataGridView_koszyk.Rows)
            {
                string sql_pz = "INSERT INTO ZNorthwind.dbo.PozycjeZamówienia(IDzamówienia,IDproduktu,CenaJednostkowa,Ilość,Rabat)" +
                    "          VALUES (@id_z,@id_p,@cena,@ilosc,@rabat)";
                var command_pz = new SqlCommand(sql_pz, DBconnection.Connection());
                command_pz.Parameters.AddWithValue("@id_z", id_zam);
                command_pz.Parameters.AddWithValue("@id_p", Convert.ToInt32(row.Cells[4].Value));
                command_pz.Parameters.AddWithValue("@cena", Convert.ToDouble(row.Cells[3].Value));
                command_pz.Parameters.AddWithValue("@ilosc", Convert.ToInt32(row.Cells[2].Value));
                command_pz.Parameters.AddWithValue("@rabat", 0);
                command_pz.ExecuteNonQuery();
            }
            DBconnection.Connection_Close(DBconnection.Connection());
            Cleaning_after_order();
        }
        private void Cleaning_after_order()
        {
            SaveBill_to_PDF();

            DialogResult dialog = MessageBox.Show("Dokonanano zakupu\nRachunek został wyeksportowany do pliku PDF\nChcesz dalej kontynuować zakupy ?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in DataGridView_koszyk.Rows)
                {
                    Global_variable.Change_counter -= (int)item.Cells[2].Value;
                    Global_variable.Bill -= Convert.ToDouble(item.Cells[3].Value) * (int)item.Cells[2].Value;
                    textBox_do_zaplaty.Text = Global_variable.Bill.ToString("0.00" + " zl");
                }
                DataGridView_koszyk.Rows.Clear();
                ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Dziękujemy za zakupy w naszym sklepie\n                    Do widzenia :)", "Alledrogo", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
        private void SaveBill_to_PDF()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Bill.pdf";
            bool fileError = false;
            MessageBox.Show("Wybierz miejsce na dysku gdzie chcesz zapisać swój rachunek", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        PdfPTable pdfTable = new PdfPTable(DataGridView_koszyk.Columns.Count - 1);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfTable.AddCell("Rachunek"); pdfTable.AddCell(" ");
                        pdfTable.AddCell(" "); pdfTable.AddCell(" ");

                        for (int i = 0; i < DataGridView_koszyk.Columns.Count - 1; i++)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(DataGridView_koszyk.Columns[i].HeaderText));
                            pdfTable.AddCell(cell);
                        }
                        for (int i = 0; i < DataGridView_koszyk.Rows.Count; i++)
                        {
                            for (int j = 0; j < DataGridView_koszyk.Rows[i].Cells.Count - 1; j++)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(DataGridView_koszyk.Rows[i].Cells[j].Value.ToString()));
                                pdfTable.AddCell(cell);
                            }
                        }
                        pdfTable.AddCell("Suma"); pdfTable.AddCell(" ");
                        pdfTable.AddCell(" "); pdfTable.AddCell(textBox_do_zaplaty.Text);
                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();
                        }
                        MessageBox.Show("Zapis pliku zakończył się sukcesem !!!", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }
        }
    }
}


