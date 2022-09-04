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







        /*using System.Security.Cryptography;
        //Global variables
        string password;



        //GenerateHash method, uses the SHA256 function to Hash the users password
        public string GenerateHash(string password)
        {
            //Get the bytes of the string
            //Encodes a set of characters into a sequence of bytes.
            //Convert password string to byte arrray
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            //SHA-256 is a patented cryptographic hash function that outputs a value that is 256 bits long.
            //data is transformed into a secure format that is unreadable unless the recipient has a key
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            return Encoding.UTF8.GetString(passwordBytes);
        }*/

    }
}
