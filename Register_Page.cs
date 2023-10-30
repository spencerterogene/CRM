using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class Register_Page : Form
    {
        public static string connectionString = @"Data Source=Manager.db;Version=3;";
        public Register_Page()
        {// C:\Users\sterogene\source\repos\CRM\bin\Debug\Manager.db
            this.Icon = new System.Drawing.Icon("iconcrm.ico");
            InitializeComponent();
        }

        private void Register_Page_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main_Page Data = new Main_Page();
            Data.Show();
            this.Hide();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Add();
        }

        public void Add()
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            if (textBoxfirstname.Text == "" || textBoxusername.ToString() == ""
                && textBoxpassword.Text == "" || textBoxphonenumber.Text == ""
                || (textBoxemail.Text == "" && IsValidEmail(textBoxemail.Text)) || textBoxlastname.Text == "")
            {
                MessageBox.Show("These Fields are required!");
            }
            else
            {
                try
                {
                    connection.Open();

                    // INSERT query
                    string sql = "INSERT INTO Costumer (FirstName, LastName, Username, Password, PhoneNumber, Email) VALUES (@value1, @value2, @value3, @value4, @value5, @value6);";
                    SQLiteCommand command = new SQLiteCommand(sql, connection);

                    command.Parameters.AddWithValue("@value1", textBoxfirstname.Text.Trim());
                    command.Parameters.AddWithValue("@value2", textBoxlastname.Text.ToUpper().Trim());
                    command.Parameters.AddWithValue("@value3", textBoxusername.Text.Trim());
                    command.Parameters.AddWithValue("@value4", textBoxpassword.Text.Trim());
                    command.Parameters.AddWithValue("@value5", textBoxphonenumber.Text.Trim());
                    command.Parameters.AddWithValue("@value6", textBoxemail.Text.Trim());

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Login_Page Data = new Login_Page();
                        Data.Show();
                        this.Hide();

                        Clear();
                        textBoxfirstname.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public void Clear()
        {
            textBoxfirstname.Clear();
            textBoxlastname.Clear();
            textBoxusername.Clear();
            textBoxpassword.Clear();
            textBoxphonenumber.Clear();
            textBoxemail.Clear();

        }
    }
}
