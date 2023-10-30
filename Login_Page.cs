using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CRM
{
    public partial class Login_Page : Form
    {
        public static string connectionString = @"Data Source=Manager.db;Version=3;";
        public Login_Page()
        {
            this.Icon = new System.Drawing.Icon("iconcrm.ico");
            InitializeComponent();
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {
            textBoxusername.Focus();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main_Page Data = new Main_Page();
            Data.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            VerifyCredentials();
        }

        private void VerifyCredentials()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
               
                connection.Open();

                // Vérification des informations d'identification
                string username = textBoxusername.Text;
                string password = textBoxpassword.Text;

                string query = "SELECT * FROM Costumer WHERE Username = @username AND Password = @password";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    object result = command.ExecuteScalar();

                    if (result != null && Convert.ToInt32(result) > 0)
                    {
                        Start_Page Data = new Start_Page();
                        Data.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: Username Or Password Invalid ");
                       
                    }
                }
                connection.Close();
            }
        }
    }
}
