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
using System.Text.RegularExpressions;

namespace Group_26_Johns_RealEstate_Management_System
{
    public partial class FormCreateAccount : Form
    {
        //Global variables, sql connection and components
        SqlConnection conn = new SqlConnection(@"Data Source=ec2-18-224-139-30.us-east-2.compute.amazonaws.com;User ID=Johns;Password=adminUser1!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter adapter;
        Boolean username, passwrd;

        public FormCreateAccount()
        {
            InitializeComponent();  //Initialize
            StyleInitialization();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try  //exception handeling
            {
                epUsername.SetError(txtUsername, "");  //Reset error provider for username, password and confirm password
                epPassword.SetError(txtPassword, "");
                epConfirmPassword.SetError(txtConfirmPassword, "");

                if (username )  //Test if username is entered
                {
                    if (txtUsername.Text != "")
                    {
                        if (passwrd)  //Test if password is entered
                        {
                            if (txtPassword.Text != "")
                            {
                                String errorMg;  //create a error message string
                                if (validatePass(txtPassword.Text, out errorMg))    //validate all password categories
                                {
                                    if (txtPassword.Text == txtConfirmPassword.Text)  //Test if passwords match
                                    {
                                        string username = txtUsername.Text;
                                        string password = txtConfirmPassword.Text;  //Assign password
                                        string passHash = GenerateHash(password);  //GenerateHash method

                                        conn.Open();  //add username and password to database

                                        SqlCommand sqlinsert = new SqlCommand($"INSERT INTO ADMINISTRATOR (Username,Password) VALUES ('{username}','{passHash}')", conn);
                                        adapter = new SqlDataAdapter();

                                        adapter.InsertCommand = sqlinsert;
                                        adapter.InsertCommand.ExecuteNonQuery();

                                        conn.Close();

                                        MessageBox.Show("Account Create Successfully");  //Display message

                                        FormLogin account = new FormLogin();  //move to login form
                                        this.Close();
                                        account.Show();

                                    }
                                    else  //Passwords not matching
                                    {
                                        epConfirmPassword.SetError(txtConfirmPassword, "Password do not match");  //Display message, reset contorols
                                        txtConfirmPassword.Text = "";
                                        txtConfirmPassword.Focus();
                                    }
                                }
                                else  //incorrect passwors structure
                                {
                                    epPassword.SetError(txtPassword, errorMg);  //Display message
                                    txtPassword.Focus();
                                    txtPassword.Text = "";
                                }
                            }
                            else  //No password enetered
                            {
                                epPassword.SetError(txtPassword, "Password Required");  //Display message
                                txtPassword.Focus();
                            }
                        }
                        else  //Never enetered password 
                        {
                            epPassword.SetError(txtPassword, "Pleaase enter your password");  //display message, reset contorols
                        }
                    }
                    else  //No username entered
                    {
                        epUsername.SetError(txtUsername, "Username Required");  //Display message
                        txtUsername.Focus();
                    }   
                }
                else  //Never entered username
                {
                    epUsername.SetError(txtUsername, "Please enter your username");  //display message, reset contorols
                } 
            }
            catch (Exception er)  //Catch exceptions
            {
                MessageBox.Show(er.Message);  //Display message
            }
        }

        private void lblCancel_Click(object sender, EventArgs e)  //cancel account creation
        {
            FormLogin account = new FormLogin();  //move to login form
            this.Close();
            account.Show();
        }

        protected void txtUsername_SetText()  //set style for username textbox
        {
            this.txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.Gray;
        }

        private void txtUsername_Enter(object sender, EventArgs e)  //set style for username textbox
        {
            if(txtUsername.ForeColor == Color.Black)
                return;
            txtUsername.Text = "";
            txtUsername.ForeColor = Color.Black;
        }

        protected void txtPassword_SetText()  //set style for password textbox
        {
            this.txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.Gray;
        }

        private void txtPassword_Enter(object sender, EventArgs e)  //set style for password textbox
        {
            if(txtPassword.ForeColor == Color.Black)
                return;
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
        }

        protected void txtConfirmPassword_SetText()  //set style confirm password textbox
        {
            this.txtConfirmPassword.Text = "Confirm Password";
            txtConfirmPassword.ForeColor = Color.Gray;
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)  //set style confirm password textbox
        {
            if(txtConfirmPassword.ForeColor == Color.Black)
                return;
            txtConfirmPassword.Text = "";
            txtConfirmPassword.ForeColor = Color.Black;
        }

        private void lblCancel_MouseEnter(object sender, EventArgs e)  //set style for Cancel label
        {
            lblCancel.ForeColor = Color.Blue;
        }

        private void lblCancel_MouseLeave(object sender, EventArgs e)  //set style for Cancel label
        {
            lblCancel.ForeColor = Color.Black;
        }

        private void StyleInitialization()  //set style for username, password, confirm password textbox
        {
            this.txtUsername.Enter += new EventHandler(txtUsername_Enter);
            txtUsername_SetText();
            this.txtPassword.Enter += new EventHandler(txtPassword_Enter);
            txtPassword_SetText();
            this.txtConfirmPassword.Enter += new EventHandler(txtConfirmPassword_Enter);
            txtConfirmPassword_SetText();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)  //set style for username textbox
        {
            username = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)  //set style for password textbox
        {
            passwrd = true;
            PasswordInitialization();
            String errorMg;
            if (validatePass(txtPassword.Text, out errorMg))    //validate all password categories
            {
                epPassword.SetError(txtPassword, "");
            }
            else  //incorrect passwors structure
            {
                epPassword.SetError(txtPassword, errorMg);  //Display message
                txtPassword.Focus();
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)  //set style for confirm password textbox
        {
            ConfirmPasswordInitialization();
        }


        private void PasswordInitialization()  //set password textbox style
        {
            txtPassword.PasswordChar = '*';
        }

        private void ConfirmPasswordInitialization()  //set password textbox style
        {
            txtConfirmPassword.PasswordChar = '*';
        }

        private void btnExit_Click(object sender, EventArgs e)  //exit program
        {
            this.Close();
        }

        private bool validatePass(string pass, out string err)  //password validation method
        {
            var trypass = pass;  //create parameter password
            err = string.Empty;  //create return string

            var Number = new Regex(@"[0-9]+");  //set regex chararter code
            var UpperChar = new Regex(@"[A-Z]+");
            var MiniMaxChars = new Regex(@".{8,15}");
            var LowerChar = new Regex(@"[a-z]+");
            var Symbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");


            if (!MiniMaxChars.IsMatch(trypass))  //validate number of characters
            {
                err = "Password should not be lesser than 8 or greater than 15 characters";
                return false;
            }
            else if (!UpperChar.IsMatch(trypass))  //validate upper case letter
            {
                err = "Password should contain at least one upper case letter";
                return false;
            }
            else if (!LowerChar.IsMatch(trypass))  //validate lower case letter
            {
                err = "Password should contain at least one lower case letter";
                return false;
            }
            else if (!Number.IsMatch(trypass))  //validate numeric value
            {
                err = "Password should contain at least one numeric value";
                return false;
            }
            else if (!Symbols.IsMatch(trypass))  //validate special charcter
            {
                err = "Password should contain at least one special case character";
                return false;
            }
            else
            {
                return true;  //return valid parameter
            }
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
    }
}
