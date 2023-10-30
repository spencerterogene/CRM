using System;
using System.Windows.Forms;

namespace CRM
{
    public partial class Start_Page : Form
    {
        public Start_Page()
        {
            this.Icon = new System.Drawing.Icon("iconcrm.ico");
            InitializeComponent();
        }

        private void Start_Page_Load(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login_Page Data = new Login_Page();
            Data.Show();
            this.Hide();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            Setting_Page Data = new Setting_Page();
            Data.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Costumer Page = new Add_Costumer();
            Page.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Edit_Costumer Data = new Edit_Costumer();
            Data.Show();
            this.Hide();
        }

        private void btnSearchExit_Click(object sender, EventArgs e)
        {
            Search_Costumer Data = new Search_Costumer();
            Data.Show();
            this.Hide();
        }
    }
}
