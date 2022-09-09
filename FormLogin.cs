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
        //Global variables, sql connection and components
        public SqlConnection conn = new SqlConnection(@"Data Source=ec2-18-224-139-30.us-east-2.compute.amazonaws.com;User ID=Johns;Password=adminUser1!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlCommand comm;
        public bool username, passwrd;
        public string name;

        public FormLogin()
        {
            InitializeComponent();  //Initialize
            StyleInitialization();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try  //exception handeling
            {
                epUsername.SetError(txtUsername, "");  //Reset error provider for username, password
                epPassword.SetError(txtPassword, "");

                if (username && txtUsername.Text != "")  //validate username entry
                {
                    if (passwrd  && txtPassword.Text != "")  //validate password entry
                    {
                        conn.Open();  //open sql connection, fetch hashed password for username
                        comm = new SqlCommand($"Select Password FROM ADMINISTRATOR WHERE Username LIKE '{txtUsername.Text}'", conn);
                        string datHash = (string)comm.ExecuteScalar();
                        conn.Close();  //close sql connection

                        string passHash = GenerateHash(txtPassword.Text);  //create password hash for entered password

                        if (datHash != null)  //validate username
                        {
                            if (datHash == passHash)  //validate password
                            {
                                name = txtUsername.Text;  //assign username to gloobal variable

                                FormMain main = new FormMain();  //continue to main form
                                this.Hide();
                                main.Show();
                            }
                            else  //invalid password
                            {
                                epPassword.SetError(txtPassword, "Invalid password");  //display message, reset contorols
                                txtPassword.Text = "";
                                txtPassword.Focus();
                            }
                        }
                        else  //invalid username
                        {
                            epUsername.SetError(txtUsername, "Invalid username");  //Display message, reset contorols
                            txtUsername.Text = "";
                            txtUsername.Focus();
                            this.txtPassword.Enter += new EventHandler(txtPassword_Enter);
                            txtPassword_SetText();
                        }
                    }
                    else
                    {
                        epPassword.SetError(txtPassword, "Pleaase enter your password");  //display message, reset contorols
                    }
                }
                else
                {
                    epUsername.SetError(txtUsername, "Please enter your username");  //Display message, reset contorols
                }
            }
            catch (SqlException error)  //catch and display error to user
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)  //close program
        {
            this.Close();
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)  //move to create new account form
        {
            FormCreateAccount newaccount = new FormCreateAccount();
            this.Hide();
            newaccount.Show();
        }

        protected void txtUsername_SetText()  //set styles for username
        {
            this.txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.Gray;
        }

        private void txtUsername_Enter(object sender, EventArgs e)  //set styles for username
        {
            if(txtUsername.ForeColor == Color.Black)
                return;
            txtUsername.Text = "";
            txtUsername.ForeColor = Color.Black;
        }

        protected void txtPassword_SetText()  //set styles for password
        {
            this.txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
        }

        private void txtPassword_Enter(object sender, EventArgs e)  //set styles for password
        {
            if (txtPassword.ForeColor == Color.Black)
                return;
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
        }

        private void lblCreateAccount_MouseEnter(object sender, EventArgs e)  //set styles for create new account label
        {
            lblCreateNewAccount.ForeColor = Color.Blue;
        }

        private void lblCreateAccount_MouseLeave(object sender, EventArgs e)  //set styles for create new account label
        {
            lblCreateNewAccount.ForeColor = Color.Black;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)  //set style for password textbox
        {
            PasswordInitialization();
            passwrd = true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)  //set style for username textbox
        {
            username = true;
        }

        private void StyleInitialization()  //set style for password, username textbox
        {
            this.txtUsername.Enter += new EventHandler(txtUsername_Enter);
            txtUsername_SetText();
            this.txtPassword.Enter += new EventHandler(txtPassword_Enter);
            txtPassword_SetText();
        }

        private void PasswordInitialization()  //set style for password textbox 
        {
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 15;
        }

        public static string GenerateHash(string password)  //GenerateHash method to hash the users password
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())  //Use input string to calculate MD5 hash
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new System.Text.StringBuilder();  //Convert the byte array to hexadecimal string
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();  //return encripted password characters
            }
        }






        private void btnSkip_Click(object sender, EventArgs e)  //temp button  (DELETE ME)
        {
            FormMain main = new FormMain();
            this.Hide();
            main.Show();
        }
    }
}
