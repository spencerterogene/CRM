using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CRM
{
    public partial class Setting_Page : Form
    {
        public static string connectionString = @"Data Source=Manager.db;Version=3;";

        public Setting_Page()
        {
            this.Icon = new System.Drawing.Icon("iconcrm.ico");
            InitializeComponent();
        }

        private void Setting_Page_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Start_Page Page = new Start_Page();
            Page.Show();
            this.Hide();
        }

        private void btnchangepassword_Click(object sender, EventArgs e)
        {
            string password = textBoxnewpassword.Text;
            string username = textBoxusername.Text;
            UpdateData1(username, password);
        }

        public void UpdateData1(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please provide values for both the username and new Password.");
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Costumer SET Password = @password WHERE Username = @username";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@username", username);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("The Password was updated successfully!");
                        Clear1();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: Database was not updated.");
                    }
                }
            }
        }
        public void Clear1()
        {
            textBoxnewpassword.Clear();
            textBoxusername.Clear();
        }

        private void btnchangenewemail_Click(object sender, EventArgs e)
        {
            string email = textBoxnewemail.Text;
            string username = textBoxusername.Text;
            UpdateData2(username, email);
        }
        public void UpdateData2(string username, string email)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please provide values for both the username and new Email.");
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Costumer SET Email = @email WHERE Username = @username";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@username", username);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("The Email was updated successfully!");
                        Clear2();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: Database was not updated.");
                    }
                }
            }
        }
        public void Clear2()
        {
            textBoxnewemail.Clear();
            textBoxusername.Clear();
        }

        private void btnnewphonenumber_Click(object sender, EventArgs e)
        {
            string phonenumber = textBoxnewphonenumber.Text;
            string username = textBoxusername.Text;
            UpdateData3(username, phonenumber);
        }

        public void UpdateData3(string username, string phonenumber)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phonenumber))
            {
                MessageBox.Show("Please provide values for both the username and new Phone.");
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Costumer SET PhoneNumber = @phonenumber WHERE Username = @username";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@phonenumber", phonenumber);
                    command.Parameters.AddWithValue("@username", username);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("The Phone was updated successfully!");
                        Clear3();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: Database was not updated.");
                    }
                }
            }
        }
        public void Clear3()
        {
            textBoxnewphonenumber.Clear();
            textBoxusername.Clear();
        }
    }
}
