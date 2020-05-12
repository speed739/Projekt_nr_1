using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alledrogo
{
    public partial class System_Logowania : Form
    {
        private string password;
        private string login;
        public System_Logowania()
        {
            InitializeComponent();
        }
        private void Log(object sender, EventArgs e)
        {
            login = textBox1.Text;
        }
        private void Hasło(object sender, EventArgs e)
        {
            password = Haslo.Text;
        }
        private void Zaloguj_button(object sender, EventArgs e)
        {
            Logowanie();
        }
        private void Rejestracja_button(object sender, EventArgs e)
        {
            Rejestracja registry = new Rejestracja();
            registry.ShowDialog();
        }
        private void Logowanie()
        {
            if (login == null || password == null)
            {
                DialogResult msg = MessageBox.Show("Musisz podać login i haslo", "Logowanie", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (msg != DialogResult.Retry)
                {
                    ActiveForm.Close();
                }
            }
            else
            {
                string sql;
                sql = "SELECT COUNT(*) FROM Klienci WHERE IDklienta = @id AND Hasło = HASHBYTES('SHA1','@haslo')";
                var command = new SqlCommand(sql, DBconnection.Connection());
                command.Parameters.AddWithValue("@id", login);
                command.Parameters.AddWithValue("@haslo", password);

                int results = (int)command.ExecuteScalar();
                if (results > 0)
                {
                    Global_variable.IDklienta = login.ToUpper();
                    Global_variable.User_status = true;
                    DBconnection.Connection_Close(DBconnection.Connection());
                    ActiveForm.Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Złe dane logowania", "Logowanie", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result != DialogResult.Retry)
                    {
                        DBconnection.Connection_Close(DBconnection.Connection());
                        ActiveForm.Close();
                    }
                }
            }
        }
    }
}
