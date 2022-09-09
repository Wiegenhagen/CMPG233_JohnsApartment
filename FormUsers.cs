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
        //public sql connection and components
        public SqlConnection conn = new SqlConnection(@"Data Source=ec2-18-224-139-30.us-east-2.compute.amazonaws.com;User ID=Johns;Password=adminUser1!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlCommand comm;
        public SqlDataAdapter adapter;
        public SqlDataReader dReader;

        public FormUsers()
        {
            InitializeComponent();  //Initialize
            PasswordInitialization();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            pChange.Visible = false;
            pDelete.Visible = false;
            if (Global.chg)  //validate change
            {
                btnChangeDelete.Text = "Change";  //change button name, panel visible, bring to front
                pChange.Visible = true;
                pChange.BringToFront();
            }
            else if (Global.dlt)  //validate delete
            {
                btnChangeDelete.Text = "Delete";  //change button name, panel visible, bring to front
                pDelete.Visible = true;
                pChange.BringToFront();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try  //exception handeling
            {
                epPassword.SetError(txtPassword, "");  //Reset error provider for username, password and confirm password, panels
                epReEnterPassword.SetError(txtReEnter, "");
                epConfirmPassword.SetError(txtConfirm, "");
                epDelete.SetError(txtDelete, "");
                epDeletePass.SetError(txtPassDelete, "");

                if (Global.chg)  //validate change
                {
                    if (txtReEnter.Text != "")  //validate re-entered password
                    {
                        conn.Open();  //open sql connection, fetch hashed password for username
                        comm = new SqlCommand($"Select Password FROM ADMINISTRATOR WHERE Username LIKE '{Global.Name}'", conn);
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

                                        comm = new SqlCommand($"UPDATE ADMINISTRATOR SET Password ='{paswordHash}' WHERE Username ='{Global.Name}'", conn);
                                        adapter = new SqlDataAdapter();

                                        adapter.InsertCommand = comm;
                                        adapter.InsertCommand.ExecuteNonQuery();

                                        conn.Close();

                                        MessageBox.Show("Password Changed Successfully" + "\nPlease log in with new password");  //Display message
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
                else if (Global.dlt)  //validate delete
                {
                    if (ValidateUsername(txtDelete.Text))
                    {
                        if (txtPassDelete.Text != "")  //validate password
                        {
                            conn.Open();  //open sql connection, fetch hashed password for username
                            comm = new SqlCommand($"Select Password FROM ADMINISTRATOR WHERE Username LIKE '{Global.Name}'", conn);
                            string datHash = (string)comm.ExecuteScalar();
                            conn.Close();  //close sql connection

                            string passHash = GenerateHash(txtPassDelete.Text);  //create password hash for entered password

                            if (datHash == passHash)
                            {
                                conn.Open();  //delete account

                                comm = new SqlCommand($"DELETE FROM ADMINISTRATOR WHERE Username = ('{txtDelete.Text}')", conn);
                                adapter = new SqlDataAdapter();

                                adapter.DeleteCommand = comm;
                                adapter.DeleteCommand.ExecuteNonQuery();

                                conn.Close();

                                MessageBox.Show("Account with username " + txtDelete.Text + " has been successfully deleted.");  //display message
                                this.Close();
                            }
                            else  //invalid password
                            {
                                epDeletePass.SetError(txtPassDelete, "Invalid password");  //display message, reset contorols
                                txtPassDelete.Text = "";
                                txtPassDelete.Focus();
                            }
                        }
                        else  //Password not entered
                        {
                            epDeletePass.SetError(txtPassDelete, "Please enter password");  //Display message
                            txtPassDelete.Focus();
                        }
                    }
                    else  //invalid username
                    {
                        epDelete.SetError(txtDelete, "Invalid Account");
                        txtDelete.Text = "";
                        txtPassDelete.Text= "";
                        txtDelete.Focus();
                    }
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

        private bool ValidateUsername(string username)
        {
            string[] usernames = new string[100];  //create array and variables
            int count = 0;

            try  //exception handeling
            {
                conn.Open();  //select usernames

                comm = new SqlCommand($"SELECT Username FROM ADMINISTRATOR", conn);
                dReader = comm.ExecuteReader();

                while (dReader.Read())  //add usernames to array
                {
                    usernames[count] = dReader.GetValue(0).ToString();
                    count++;
                }

                conn.Close();
            }
            catch (SqlException error)  //catch exceptions
            {
                MessageBox.Show(error.Message);
            }

            for (int i = 0; i < count; i++)  //validate username
            {
                if (username == usernames[i])
                {
                    return true;  //return true
                }
            }

            return false;  //return false
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
            txtPassDelete.PasswordChar = '*';
        }
    }
}
