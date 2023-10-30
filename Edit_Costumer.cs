using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CRM
{
    public partial class Edit_Costumer : Form
    {
        public static string connectionString = @"Data Source=Manager.db;Version=3;";
        public Edit_Costumer()
        {
            this.Icon = new System.Drawing.Icon("iconcrm.ico");
            InitializeComponent();
        }

        private void Edit_Costumer_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Start_Page Data = new Start_Page();
            Data.Show();
            this.Hide();
        }

        private void btnupdatecostumer_Click(object sender, EventArgs e)
        {
            string email = textBoxemail.Text;
            string nouvelleAdresse = textBoxadresse.Text;
            string nouvelleDate = textBoxdate.Text;
            string nouveauSalesman = textBoxsalesmanname.Text;
            string nouveauTypeProduit = textBoxtypeproduct.Text;
            string nouvelleDescriptionProduit = textBoxproductdescription.Text;
            string nouvelleQuantiteProduit = textBoxproductquantity.Text;
            string nouveauMontantTotal = textBoxtotalamount.Text;

            UpdateData(email, nouvelleAdresse, nouvelleDate, nouveauSalesman, nouveauTypeProduit, nouvelleDescriptionProduit, nouvelleQuantiteProduit, nouveauMontantTotal);

        }

        public void UpdateData(string email, string nouvelleAdresse, string nouvelleDate, string nouveauSalesman, string nouveauTypeProduit, string nouvelleDescriptionProduit, string nouvelleQuantiteProduit, string nouveauMontantTotal)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(nouvelleAdresse) || string.IsNullOrEmpty(nouvelleDate) ||
                string.IsNullOrEmpty(nouveauSalesman) || string.IsNullOrEmpty(nouveauTypeProduit) ||
                string.IsNullOrEmpty(nouvelleDescriptionProduit) || string.IsNullOrEmpty(nouvelleQuantiteProduit) ||
                string.IsNullOrEmpty(nouveauMontantTotal))
            {
                MessageBox.Show("Please provide values for all the parameters.");
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string username = comboBoxcostumer.SelectedItem.ToString();

                string query = "UPDATE Employer SET Adresse = @NouvelleAdresse, Date = @NouvelleDate, Salesman = @NouveauSalesman, " +
                               "ProductType = @NouveauTypeProduit, ProductDescription = @NouvelleDescriptionProduit, " +
                               "ProductQuantity = @NouvelleQuantiteProduit, TotalAmount = @NouveauMontantTotal, Email = @Email " +
                               "WHERE Username = @Username";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NouvelleAdresse", nouvelleAdresse);
                    command.Parameters.AddWithValue("@NouvelleDate", nouvelleDate);
                    command.Parameters.AddWithValue("@NouveauSalesman", nouveauSalesman);
                    command.Parameters.AddWithValue("@NouveauTypeProduit", nouveauTypeProduit);
                    command.Parameters.AddWithValue("@NouvelleDescriptionProduit", nouvelleDescriptionProduit);
                    command.Parameters.AddWithValue("@NouvelleQuantiteProduit", nouvelleQuantiteProduit);
                    command.Parameters.AddWithValue("@NouveauMontantTotal", nouveauMontantTotal);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Username", username);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("The data was updated successfully!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: Database was not updated.");
                    }
                }
            }
        }

        public void Clear()
        {
            textBoxadresse.Clear();
            textBoxdate.Clear();
            textBoxsalesmanname.Clear();
            textBoxtypeproduct.Clear();
            textBoxproductdescription.Clear();
            textBoxemail.Clear();
            textBoxproductquantity.Clear();
            textBoxtotalamount.Clear();
        }

        private void btnsearchcostumer_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        public void SearchData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectedData = comboBoxcostumer.SelectedItem.ToString();
                // Create and execute the query
                string query = "SELECT Email, Adresse, Date, Salesman, ProductType, ProductDescription, " +
                               "ProductQuantity, TotalAmount FROM Employer WHERE Username = @selectedData";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedData", selectedData); // Assign the parameter value
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string Email = reader["Email"].ToString();
                            string Adresse = reader["Adresse"].ToString();
                            string Date = reader["Date"].ToString();
                            string Salesman = reader["Salesman"].ToString();
                            string ProductType = reader["ProductType"].ToString();
                            string ProductDescription = reader["ProductDescription"].ToString();
                            string ProductQuantity = reader["ProductQuantity"].ToString();
                            string TotalAmount = reader["TotalAmount"].ToString();

                            textBoxemail.Text = Email;
                            textBoxadresse.Text = Adresse;
                            textBoxdate.Text = Date;
                            textBoxsalesmanname.Text = Salesman;
                            textBoxtypeproduct.Text = ProductType;
                            textBoxproductdescription.Text = ProductDescription;
                            textBoxproductquantity.Text = ProductQuantity;
                            textBoxtotalamount.Text = TotalAmount;
                        }

                        reader.Close();
                        connection.Close();
                    }
                }
            }
        }

        public void ReadData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Create and execute the query
                string query = "SELECT Username FROM Employer";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Read the data using a SqlDataReader
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // Clear the ComboBox before populating it
                        comboBoxcostumer.Items.Clear();

                        // Loop through the data and add items to the ComboBox
                        while (reader.Read())
                        {
                            string Username = reader.GetString(0);
                            comboBoxcostumer.Items.Add(Username);
                        }
                    }
                }
            }
        }
    }

}
