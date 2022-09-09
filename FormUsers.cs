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
    public partial class FormUsers : Form
    {
        //Global sql connection and components
        public SqlConnection conn = new SqlConnection(@"Data Source=ec2-18-224-139-30.us-east-2.compute.amazonaws.com;User ID=Johns;Password=adminUser1!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlCommand comm;
        public SqlDataAdapter adapter;

        public FormUsers()
        {
            InitializeComponent();  //Initialize
            PasswordInitialization();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try  //exception handeling
            {
                epPassword.SetError(txtReEnter, "");  //Reset error provider for username, password and confirm password
                epReEnterPassword.SetError(txtPassword, "");
                epConfirmPassword.SetError(txtConfirm, "");

                if (txtReEnter.Text != "")  //validate re-entered password
                {
                    FormLogin username = new FormLogin();

                    conn.Open();  //open sql connection, fetch hashed password for username
                    comm = new SqlCommand($"Select Password FROM ADMINISTRATOR WHERE Username LIKE '{username.name}'", conn);
                    string datHash = (string)comm.ExecuteScalar();
                    conn.Close();  //close sql connection

                    string passHash = GenerateHash(txtReEnter.Text);  //create password hash for entered password

                    if (datHash == passHash)
                    {
                        if (txtPassword.Text != "")
                        {
                            String errorMg;  //create a error message string
                            if (validatePass(txtPassword.Text, out errorMg))    //validate all password categories
                            {
                                if (txtPassword.Text == txtConfirm.Text)  //Test if passwords match
                                {
                                    string password = txtConfirm.Text;  //Assign password
                                    string paswordHash = GenerateHash(password);  //GenerateHash method

                                    conn.Open();  //add new password to database

                                    comm = new SqlCommand($"UPDATE ADMINISTRATOR (Password) VALUES ('{paswordHash}')", conn);
                                    adapter = new SqlDataAdapter();

                                    adapter.InsertCommand = comm;
                                    adapter.InsertCommand.ExecuteNonQuery();

                                    conn.Close();

                                    MessageBox.Show("Password Changed Successfully");  //Display message
                                    this.Close();  //close form
                                }
                                else  //Passwords not matching
                                {
                                    epConfirmPassword.SetError(txtConfirm, "Password do not match");  //Display message, reset contorols
                                    txtConfirm.Text = "";
                                    txtConfirm.Focus();
                                }
                            }
                            else  //incorrect passwors structure
                            {
                                epReEnterPassword.SetError(txtPassword, errorMg);  //Display message
                                txtPassword.Focus();
                                txtPassword.Text = "";
                            }
                        }
                        else  //No password enetered
                        {
                            epReEnterPassword.SetError(txtPassword, "Password Required");  //Display message
                            txtPassword.Focus();
                        }
                    }
                    else  //invalid password
                    {
                        epReEnterPassword.SetError(txtReEnter, "Invalid password");  //display message, reset contorols
                        txtReEnter.Text = "";
                        txtReEnter.Focus();
                    }
                }
                else  //Password not re-entered
                {
                    epReEnterPassword.SetError(txtReEnter, "Please re-enter password");  //Display message
                    txtReEnter.Focus();
                } 
            }
            catch (SqlException error)  //catch and display error to user
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)  //exit form
        {
            this.Close();
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

        private void PasswordInitialization()  //set password textbox style
        {
            txtReEnter.PasswordChar = '*';
            txtPassword.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';
        }
    }
}
