using System;
using System.Data;
using System.Windows.Forms;

namespace Alledrogo
{
    public partial class MainForm : Form
    {
        System_Logowania Log = new System_Logowania();
        Koszyk Basket = new Koszyk();
       
        public MainForm()
        {
            InitializeComponent();
        }
        private void button_Zaloguj_MouseClick(object sender, MouseEventArgs e)
        {
            Log.ShowDialog(this);
            if (Global_variable.User_status == true)
            {
                lb_user_status.Text = Global_variable.IDklienta;
                button_zaloguj.Visible = false;
                button_wyloguj.Visible = true;
            }
        }
        private void button_Wyloguj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wylogowano pomyślnie", "Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
            Global_variable.User_status = false;
            lb_user_status.Text = "Nie zalogowany";
            button_wyloguj.Visible = false;
            button_zaloguj.Visible = true;
        }
        public void Button_koszyk_Click(object sender, EventArgs e)
        {
            if (Global_variable.User_status == true)
            {
                
                Visible = false;
                Basket.ShowDialog();
                Visible = true;
                koszyk_counter.Text = Global_variable.Change_counter.ToString();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Aby przejść dalej, należy się zalogować\n             " +
                         "Chcesz zrobić to teraz ?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    Log.ShowDialog();
                    if (Global_variable.User_status == true)
                    {
                        lb_user_status.Text = Global_variable.IDklienta;
                        button_zaloguj.Visible = false;
                        button_wyloguj.Visible = true;
                        Visible = false;
                        Basket.ShowDialog();
                        Visible = true;
                        koszyk_counter.Text = Global_variable.Change_counter.ToString();
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zNorthwindDataSet.Produkty' . Możesz go przenieść lub usunąć.
            this.produktyTableAdapter.Fill(this.zNorthwindDataSet.Produkty);

        }
        private void Button_dodaj_Click(object sender, EventArgs e)
        {
            if (produkty_DataGridView.SelectedRows.Count > 0)// Jeśli jest coś zaznaczone 
            {
                if (Basket.DataGridView_koszyk.Rows.Count > 0)// Jeśli jest coś w koszyku 
                {
                    for (int i = 0; i < produkty_DataGridView.SelectedRows.Count; i++)// iteracja po zaznaczonych elementach 
                    {
                        bool exists = false; // pomocnik do sprawdzenia czy w zaznaczonych elementach znajduje sie element juz istniejacy w koszyku
                        for (int k = 0; k < Basket.DataGridView_koszyk.Rows.Count; k++) // iteracja po elementach w koszyku 
                        {
                            if (produkty_DataGridView.SelectedRows[i].Cells[0].Value.ToString() == Basket.DataGridView_koszyk.Rows[k].Cells[0].Value.ToString())
                            {
                                Basket.DataGridView_koszyk.Rows[k].Cells[2].Value = ((int)Basket.DataGridView_koszyk.Rows[k].Cells[2].Value) + 1;
                                Global_variable.Bill += Convert.ToDouble(Basket.DataGridView_koszyk.Rows[k].Cells[3].Value);
                                Basket.textBox_do_zaplaty.Text = Global_variable.Bill.ToString() + " zl";
                                koszyk_counter.Text = (++Global_variable.Change_counter).ToString();
                                exists = true;
                            }
                        }
                        if (exists == false)
                        {
                            Dodawanie(i);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < produkty_DataGridView.SelectedRows.Count; i++)
                    {
                        Dodawanie(i);
                    }
                }
            }
        }
        private void textBox_szukaj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = zNorthwindDataSet.Produkty.DefaultView;
                if (comboBox_kategorie.Text == "[ Wybierz ]")
                {
                    dv.RowFilter = string.Format("NazwaProduktu like '%{0}%'", textBox_szukaj.Text);
                    produkty_DataGridView.DataSource = dv.ToTable();
                }
                else
                {
                    dv.RowFilter = string.Format("NazwaProduktu like '%{0}%' AND IDKategorii = {1}", textBox_szukaj.Text, comboBox_kategorie.SelectedIndex);
                    produkty_DataGridView.DataSource = dv.ToTable();
                }
            }
        }
        private void comboBox_kategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = zNorthwindDataSet.Produkty.DefaultView;
            if (comboBox_kategorie.SelectedIndex == 0)
            {
                dv.RowFilter = string.Format("IDKategorii < 9");
                produkty_DataGridView.DataSource = dv.ToTable();
            }
            else
            {
                dv.RowFilter = string.Format("IDKategorii = {0}", comboBox_kategorie.SelectedIndex);
                produkty_DataGridView.DataSource = dv.ToTable();
            }
        }
        private void Dodawanie(int i)
        {
            int n = Basket.DataGridView_koszyk.Rows.Add();
            Basket.DataGridView_koszyk.Rows[n].Cells[0].Value = produkty_DataGridView.SelectedRows[i].Cells[0].Value; //Nazwa_Produktu
            Basket.DataGridView_koszyk.Rows[n].Cells[1].Value = produkty_DataGridView.SelectedRows[i].Cells[1].Value; //Ilosc_Jednostkowa
            Basket.DataGridView_koszyk.Rows[n].Cells[2].Value = 1; //ilosc
            Basket.DataGridView_koszyk.Rows[n].Cells[3].Value = produkty_DataGridView.SelectedRows[i].Cells[2].Value; //Cena_Jednostkowa
            Basket.DataGridView_koszyk.Rows[n].Cells[4].Value = produkty_DataGridView.SelectedRows[i].Cells[3].Value;

            Global_variable.Bill += Convert.ToDouble(produkty_DataGridView.SelectedRows[i].Cells[2].Value);
            Basket.textBox_do_zaplaty.Text = Global_variable.Bill.ToString() + " zl";
            koszyk_counter.Text = (++Global_variable.Change_counter).ToString();
        }
        private void button_Rejestracja_Click(object sender, EventArgs e)
        {
            Rejestracja registry = new Rejestracja();
            registry.ShowDialog();
        }
        private void produkty_DataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Button_dodaj_Click(sender, e);
        }
    }
}
