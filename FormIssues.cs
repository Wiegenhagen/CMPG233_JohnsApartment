using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Group_26_Johns_RealEstate_Management_System
{
    public partial class FormIssues : Form
    {
        public FormIssues()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text != "")  //validate subject line
            {
                lblErrorSubject.Visible = false;  //reset error code subject
                if (emailValidation(txtEmail.Text))
                {
                    lblErrorEmail.Visible = false;  //reset error code email
                    if (rtxtMessage.Text != "")
                    {
                        lblErrorMessage.Visible = false;  //reset error code message
                        MessageBox.Show("Request Created Successfully." + "\nPlease check your email for your support ticket.");  //user output
                        this.Close();  //close form
                    }
                    else  //no message
                    {
                        lblErrorMessage.Visible = true;  //set error message
                        rtxtMessage.Focus();
                    }
                }
                else  //invalid or no email
                {
                    lblErrorEmail.Visible = true;  //set error email, reset conrols
                    txtEmail.Text = "";
                    txtEmail.Focus();
                }
            }
            else  //no subject
            {
                lblErrorSubject.Visible = true;  //set error subject
                txtSubject.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)  //exit form
        {
            this.Close();  
        }

        public bool emailValidation(string email)  //method to validate validd email address
        {
            string validation = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";  //validation string

            if (Regex.IsMatch(email, validation))  //validate input
            {
                if (Regex.Replace(email, validation, string.Empty).Length == 0)
                {
                    return true;  //return true
                }
            }
            return false;  //return false
        }
    }
}
