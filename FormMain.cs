using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_26_Johns_RealEstate_Management_System
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin username = new FormLogin();
            lblWelcome.Text = "Welcome, " + username.name;
            DateTime today = DateTime.Today;
            lblDate.Text = today.ToString("dd MMMM yyy");
        }
    }
}
