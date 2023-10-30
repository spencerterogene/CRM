using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            this.Icon = new System.Drawing.Icon("iconcrm.ico");
            InitializeComponent();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login_Page Page = new Login_Page();
            Page.Show();
            this.Hide();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Register_Page Page = new Register_Page();
            Page.Show();
            this.Hide();
        }
    }
}
