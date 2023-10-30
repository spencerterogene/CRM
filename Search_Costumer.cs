using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CRM
{
    public partial class Search_Costumer : Form
    {
        public static string connectionString = @"Data Source=Manager.db;Version=3;";
        public Search_Costumer()
        {
            this.Icon = new System.Drawing.Icon("iconcrm.ico");
            InitializeComponent();
        }

        private void Search_Costumer_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            ReadData();
            comboBoxcostumerinfo.Items.Add("PhoneNumber");
            comboBoxcostumerinfo.Items.Add("Date");
            comboBoxcostumerinfo.Items.Add("ProductDescription");
            comboBoxcostumerinfo.Items.Add("Salesman");
            comboBoxcostumerinfo.Items.Add("WayCommunicate");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Start_Page Data = new Start_Page();
            Data.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            ShowDataToDataGridView();
        }

        public void LoadDataToDataGridView()
        {
            // Create a DataTable to hold the data.
            DataTable dataTable = new DataTable();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    // Open the connection.
                    connection.Open();

                    //  "YourQuery" with the SQL query to fetch data from your database.
                    string query = "SELECT * FROM Employer ";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Add the parameter to the command.
                        //command.Parameters.AddWithValue("@username", username);

                        using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command))
                        {
                            // Fill the DataTable with the data from the database.
                            dataAdapter.Fill(dataTable);
                        }
                    }

                    // Close the connection.
                    connection.Close();
                }

                // Set the DataTable as the data source for the DataGridView.
                dataGridViewcostumerdatasingle.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the process.
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public void ShowDataToDataGridView()
        {
            // Create a DataTable to hold the data.
            DataTable dataTable = new DataTable();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string username = comboBoxusername.SelectedItem.ToString();
                    string data = comboBoxcostumerinfo.SelectedItem.ToString();
                    string query = $"SELECT {data} FROM Employer WHERE Username = @username";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Add the parameter to the command.
                        command.Parameters.AddWithValue("@username", username);
                        //command.Parameters.AddWithValue("@data", data);

                        using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command))
                        {
                            // Fill the DataTable with the data from the database.
                            dataAdapter.Fill(dataTable);
                        }
                    }
                    // Close the connection.
                    connection.Close();

                }
                int Items = comboBoxcostumerinfo.Items.Count;
                string info = comboBoxcostumerinfo.SelectedItem.ToString();
                switch (Items)
                {
                    case 1:
                        info = "PhoneNumber";
                        dataGridViewcostumerinfos.DataSource = dataTable;
                        break;

                    case 2:
                        info = "Date";
                        dataGridViewcostumerinfos.DataSource = dataTable;
                        break;

                    case 3:
                        info = "ProductDescription";
                        dataGridViewcostumerinfos.DataSource = dataTable;
                        break;

                    case 4:
                        info = "WayCommunicate";
                        dataGridViewcostumerinfos.DataSource = dataTable;
                        break;

                    case 5:
                        info = "Salesman";
                        dataGridViewcostumerinfos.DataSource = dataTable;
                        break;
                }

            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the process.
                MessageBox.Show("An error occurred: " + ex.Message);
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
                        comboBoxusername.Items.Clear();

                        // Loop through the data and add items to the ComboBox
                        while (reader.Read())
                        {
                            string Username = reader.GetString(0);
                            comboBoxusername.Items.Add(Username);
                        }
                    }
                }
            }
        }
    }
}
