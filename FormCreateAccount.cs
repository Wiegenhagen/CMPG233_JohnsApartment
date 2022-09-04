using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Group_26_Johns_RealEstate_Management_System
{
    public partial class FormCreateAccount : Form
    {
        //Global variables
        string password;
        string username;

        public FormCreateAccount()
        {
            InitializeComponent();
        }

        private void FormCreateAccount_Load(object sender, EventArgs e)
        {
            this.txtUsername.Enter += new EventHandler(txtUsername_Enter);
            txtUsername_SetText();
            this.txtPassword.Enter += new EventHandler(txtPassword_Enter);
            txtPassword_SetText();
            this.txtConfirmPassword.Enter += new EventHandler(txtConfirmPassword_Enter);
            txtConfirmPassword_SetText();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try  //exception handeling
            {
                epUsername.SetError(txtUsername, "");  //Reset error provider for requiered password
                epPassword.SetError(txtPassword, "");  //Reset error provider for requiered password

                if (txtUsername.Text != "")
                {
                    if (txtPassword.Text != "")  //Test if password is entered
                    {
                        if (txtPassword.Text == txtConfirmPassword.Text)  //Test if passwords match
                        {
                            username = txtUsername.Text;
                            password = txtConfirmPassword.Text;  //Assign password

                            //GenerateHash(password);  //GenerateHash method



                            FormLogin account = new FormLogin();
                            this.Close();
                            account.Show();

                        }
                        else  //Passwords not matching
                        {
                            epPassword.SetError(txtPassword, "Password do not match");  //Display message, reset contorols
                            txtPassword.Text = "";
                            txtConfirmPassword.Text = "";
                            txtPassword.Focus();
                        }

                    }
                    else  //No password enetered
                    {
                        epPassword.SetError(txtPassword, "Password Required");  //Display message
                        txtPassword.Focus();
                    }
                }
                else  //no username entered
                {
                    epUsername.SetError(txtUsername, "Username Required");  //Display message
                    txtUsername.Focus();
                }
            }
            catch (Exception er)  //Catch exceptions
            {
                MessageBox.Show(er.Message);  //Display message
            }
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
            if(txtPassword.ForeColor == Color.Black)
                return;
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
        }

        protected void txtConfirmPassword_SetText()
        {
            this.txtConfirmPassword.Text = "Confirm Password";
            txtConfirmPassword.ForeColor = Color.Gray;
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if(txtConfirmPassword.ForeColor == Color.Black)
                return;
            txtConfirmPassword.Text = "";
            txtConfirmPassword.ForeColor = Color.Black;
        }



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
        }


    }
}
