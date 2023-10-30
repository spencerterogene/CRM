using System;
using System.Data.SQLite;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRM
{
    public partial class Add_Costumer : Form
    {
        public static string connectionString = @"Data Source=Manager.db;Version=3;";
        public Add_Costumer()
        {
            this.Icon = new System.Drawing.Icon("iconcrm.ico");
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Start_Page Data = new Start_Page();
            Data.Show();
            this.Hide();
        }

        private void btnaddcostumer_Click(object sender, EventArgs e)
        {
            Add();
        }

        public void Add()
        {


            SQLiteConnection connection = new SQLiteConnection(connectionString);

            if (textBoxfirstname.Text == "" || textBoxlastname.Text == "" && textBoxgender.Text == ""
              || (textBoxemail.Text == "" && IsValidEmail(textBoxemail.Text)) || textBoxadresse.Text == ""
              || textBoxdate.Text == "" || textBoxtotalamount.Text == "" || textBoxphonenumber.Text == ""
              || textBoxtypeproduct.Text == "" || textBoxdescriptionproduct.Text == "" || textBoxproductquantity.Text == ""
              || textBoxwaycommunicate.Text == "")
            {
                MessageBox.Show("These Fields are required!");
            }
            else
            {
                try
                {
                    connection.Open();

                    // INSERT query
                    string sql = "INSERT INTO Employer (FirstName, LastName, Gender, Email, " +
                        "Adresse, Date,TotalAmount,Salesman,PhoneNumber,Username,ProductType,ProductDescription,ProductQuantity,WayCommunicate)" +
                        " VALUES (@value1, @value2, @value3, @value4, @value5, @value6,@value7,@value8,@value9,@value10," +
                        "@value11,@value12,@value13,@value14);";
                    SQLiteCommand command = new SQLiteCommand(sql, connection);

                    command.Parameters.AddWithValue("@value1", textBoxfirstname.Text.Trim());
                    command.Parameters.AddWithValue("@value2", textBoxlastname.Text.ToUpper().Trim());
                    command.Parameters.AddWithValue("@value3", textBoxgender.Text.Trim());
                    command.Parameters.AddWithValue("@value4", textBoxemail.Text.Trim());
                    command.Parameters.AddWithValue("@value5", textBoxadresse.Text.Trim());
                    command.Parameters.AddWithValue("@value6", textBoxdate.Text.Trim());
                    command.Parameters.AddWithValue("@value7", textBoxtotalamount.Text.Trim());
                    command.Parameters.AddWithValue("@value8", textBoxsalesman.Text.Trim());
                    command.Parameters.AddWithValue("@value9", textBoxphonenumber.Text.Trim());
                    command.Parameters.AddWithValue("@value10", textBoxusername.Text.Trim());
                    command.Parameters.AddWithValue("@value11", textBoxtypeproduct.Text.Trim());
                    command.Parameters.AddWithValue("@value12", textBoxdescriptionproduct.Text.Trim());
                    command.Parameters.AddWithValue("@value13", textBoxproductquantity.Text.Trim());
                    command.Parameters.AddWithValue("@value14", textBoxwaycommunicate.Text.Trim());


                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Inerted Successfully!!!");
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
            textBoxgender.Clear();
            textBoxemail.Clear();
            textBoxadresse.Clear();
            textBoxdate.Clear();
            textBoxtotalamount.Clear();
            textBoxsalesman.Clear();
            textBoxphonenumber.Clear();
            textBoxusername.Clear();
            textBoxtypeproduct.Clear();
            textBoxdescriptionproduct.Clear();
            textBoxproductquantity.Clear();
            textBoxwaycommunicate.Clear();


        }
        private void Add_Costumer_Load(object sender, EventArgs e)
        {

        }

    }
}
