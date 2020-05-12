using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Alledrogo
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }
        private bool Check_password()
        {
            if (textBox_Haslo.Text == textBox_powtorz_haslo.Text)
            {
                label_rozne_hasla.Visible = false;
                return true;
            }
            return false;
        }
        private bool Check_login()
        {
            string sql;
            sql = "SELECT COUNT(*) FROM Klienci WHERE IDklienta = @Id";
            var command = new SqlCommand(sql, DBconnection.Connection());
            command.Parameters.AddWithValue("@Id", textBox_Login.Text);

            int results = (int)command.ExecuteScalar();
            if (results > 0)
            {
                return false; // istnieje uzytkownik
            }
            label_login_istnieje.Visible = false;
            return true; // nie istnieje 
        }
        private void Rejestruj_button(object sender, EventArgs e)
        {

            if (textBox_Login.Text.Length == 5 && Check_login() == true && Check_password() == true &&
                textBox_Imie.Text.Length > 0 && textBox_Nazwisko.Text.Length > 0 &&
                textBox_Adres.Text.Length > 0 && textBox_Kraj.Text.Length > 0 &&
                textBox_Miasto.Text.Length > 0)
                {
                    Create();
                    DialogResult message = MessageBox.Show("Utworzono konto", "Rejestracja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActiveForm.Close();
                }
            else
                {
                    DialogResult message = MessageBox.Show("Nie wypełniono wymaganych pól !!!\nlub zostały wypełnione źle, czytaj Legende ", "Błąd", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (message == DialogResult.Cancel)
                    {
                        ActiveForm.Close();
                    }
                }
            if (Check_password() == false)
            {
                label_rozne_hasla.Visible = true;
            }
            if (Check_login() == false)
            {
                label_login_istnieje.Visible = true;
            }
        }
        private void Create()
        {
            string sql = "INSERT INTO ZNorthwind.dbo.Klienci(IDklienta,NazwaFirmy,Miasto,Adres,KodPocztowy,Kraj,Telefon,Hasło)" +
                "VALUES (@id,@nazwafirmy,@miasto,@adres,@kodpocztowy,@kraj,@telefon,HASHBYTES('SHA1','@haslo'))";
            var command = new SqlCommand(sql, DBconnection.Connection());
            command.Parameters.AddWithValue("@nazwafirmy", textBox_Imie.Text + " " + textBox_Nazwisko.Text);
            command.Parameters.AddWithValue("@id", textBox_Login.Text.ToUpper());
            command.Parameters.AddWithValue("@miasto", textBox_Miasto.Text);
            command.Parameters.AddWithValue("@adres", textBox_Adres.Text);
            command.Parameters.AddWithValue("@kodpocztowy", textBox_Kod_pocztowy.Text);
            command.Parameters.AddWithValue("@kraj", textBox_Kraj.Text);
            command.Parameters.AddWithValue("@telefon", textBox_Telefon.Text);
            command.Parameters.AddWithValue("@haslo", textBox_Haslo.Text);
            command.ExecuteNonQuery();

            DBconnection.Connection_Close(DBconnection.Connection());
        }
    }
}
