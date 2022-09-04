using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Group_26_Johns_RealEstate_Management_System
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.txtUsername.Enter += new EventHandler(txtUsername_Enter);
            txtUsername_SetText();
            this.txtPassword.Enter += new EventHandler(txtPassword_Enter);
            txtPassword_SetText();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //validate login  **

            FormMain main = new FormMain();
            this.Hide();
            main.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void txtUsername_SetText()
        {
            this.txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.Gray;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.ForeColor == Color.Black)
                return;
            txtUsername.Text = "";
            txtUsername.ForeColor = Color.Black;
        }

        protected void txtPassword_SetText()
        {
            this.txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.ForeColor == Color.Black)
                return;
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            //FormLogin account = new FormLogin();
            FormCreateAccount newaccount = new FormCreateAccount();
            this.Hide();
            newaccount.Show();
        }

        private void lblCreateAccount_MouseEnter(object sender, EventArgs e)
        {
            lblCreateNewAccount.ForeColor = Color.Blue;
        }

        private void lblCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            lblCreateNewAccount.ForeColor = Color.Black;
        }

        private void btnSkip_Click(object sender, EventArgs e)  //temp button
        {
            FormMain main = new FormMain();
            this.Hide();
            main.Show();
        }
    }
}
