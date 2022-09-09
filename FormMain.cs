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
        //Global variables
        public bool chg, dlt;

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

        private void contactHelpDeskToolStripMenuItem_Click(object sender, EventArgs e)  //contact information
        {
            MessageBox.Show("Help Desk Contact Information:" +"\n\nOffice Hours Number: +2761 375 1204" +"\nAfter Hours Emergency Number: +2778 173 2231" + "\n\nFeel free to contact us within business hours." + "\nIn case of an emergency please contact the after hours number.");
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIssues issue = new FormIssues();
            issue.ShowDialog();
        }

        private void exitProgramToolStripMenuItem1_Click(object sender, EventArgs e)  //exit program
        {
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)  //change password
        {
            FormUsers change = new FormUsers();
            change.ShowDialog();
            chg = true;
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)  //add new user
        {
            FormCreateNewAccount newaccount = new FormCreateNewAccount();
            newaccount.ShowDialog();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)  //delete a user
        {
            FormUsers change = new FormUsers();
            change.ShowDialog();
            dlt = true;
        }
    }
}
