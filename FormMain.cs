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
    public partial class FormMain : Form
    {
        //public sql connection and components
        public SqlConnection conn = new SqlConnection(@"Data Source=ec2-18-224-139-30.us-east-2.compute.amazonaws.com;User ID=Johns;Password=adminUser1!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlCommand comm;
        public SqlDataAdapter adapter;
        public SqlDataReader dReader;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)  //load username and date
        {
            lblWelcome.Text = "Welcome, " + Global.Name;

            DateTime today = DateTime.Today;
            lblDate.Text = today.ToString("dd MMMM yyy");

            lblTAppartments.Text = CountApartments().ToString(); 
            lblTResidents.Text = CountResidents().ToString();
            lblTUsers.Text = CountUsers().ToString();
        }

        private void contactHelpDeskToolStripMenuItem_Click(object sender, EventArgs e)  //contact information
        {
            MessageBox.Show("Help Desk Contact Information:" +"\n\nOffice Hours Number: +2761 375 1204" +"\nAfter Hours Emergency Number: +2778 173 2231" + "\n\nFeel free to contact us within business hours." + "\nIn case of an emergency please contact the after hours number.");
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)  //report an issue
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
            Global.chg = true;
            Global.dlt = false;
            change.ShowDialog();
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)  //add new user
        {
            FormCreateNewAccount newaccount = new FormCreateNewAccount();
            newaccount.ShowDialog();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)  //delete a user
        {
            FormUsers change = new FormUsers();
            Global.dlt = true;
            Global.chg = false;
            change.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)  //log out
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private int CountApartments()  //count apartments entries in database
        {
            int count = 0;  //create count variables

            try  //exception handeling
            {
                conn.Open();  //select Apartments

                comm = new SqlCommand($"SELECT * FROM APARTMENT", conn);
                dReader = comm.ExecuteReader();

                while (dReader.Read())  //count entries
                {
                    count++;
                }

                conn.Close();
            }
            catch (SqlException error)  //catch exceptions
            {
                MessageBox.Show(error.Message);
            }

            return count;  //return count
        }

        private int CountResidents()  //count reidents entries in database
        {
            int count = 0;  //create count variables

            try  //exception handeling
            {
                conn.Open();  //select Residents

                comm = new SqlCommand($"SELECT * FROM RESIDENT", conn);
                dReader = comm.ExecuteReader();

                while (dReader.Read())  //count entries
                {
                    count++;
                }

                conn.Close();
            }
            catch (SqlException error)  //catch exceptions
            {
                MessageBox.Show(error.Message);
            }

            return count;  //return count
        }

        private int CountUsers()  //count user entries in database
        {
            int count = 0;  //create count variables

            try  //exception handeling
            {
                conn.Open();  //select Users

                comm = new SqlCommand($"SELECT * FROM ADMINISTRATOR", conn);
                dReader = comm.ExecuteReader();

                while (dReader.Read())  //count entries
                {
                    count++;
                }

                conn.Close();
            }
            catch (SqlException error)  //catch exceptions
            {
                MessageBox.Show(error.Message);
            }

            return count;  //return count
        }

        private void appartmentsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT RESIDENT.Resident_ID,CONCAT(RESIDENT.First_Name+' ',RESIDENT.Last_Name+' ') AS Name," +
                "APARTMENT.Occupation_Date,APARTMENT.Furnished,APARTMENT.Apartment_Number FROM RESIDENT " +
                "JOIN APARTMENT ON RESIDENT.Resident_ID = APARTMENT.Resident_ID;";
            GenericReportForm fullForm = new GenericReportForm(query, "Apartment Report Of Johns Apartments");
            fullForm.ShowDialog();
        }

        private void residentsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT RESIDENT.ID_Number,CONCAT(RESIDENT.First_Name+' ',RESIDENT.Last_Name+' ') AS Name," +
                "RESIDENT.Cell_Number,RESIDENT.Account_Number, RESIDENT.Branch_Code FROM RESIDENT";
            GenericReportForm fullForm = new GenericReportForm(query, "Resident Report Of Johns Apartments");
            fullForm.ShowDialog();
        }

        private void fullReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT RESIDENT.Resident_ID,CONCAT(RESIDENT.First_Name+' ',RESIDENT.Last_Name+' ') AS Name," +
                "RESIDENT.Cell_Number,RESIDENT.ID_Number,RESIDENT.Branch_Code,RESIDENT.Account_Number," +
                "APARTMENT.Apartment_ID,APARTMENT.Occupation_Date,APARTMENT.Furnished,APARTMENT.Apartment_Number," +
                "BANK.Bank_ID,BANK.Bank_Name FROM RESIDENT JOIN APARTMENT ON RESIDENT.Resident_ID = APARTMENT.Resident_ID " +
                "JOIN BANK ON RESIDENT.Bank_ID = BANK.Bank_ID;";
            GenericReportForm fullForm = new GenericReportForm(query, "Full Report Of Johns Apartments");
            fullForm.ShowDialog();
        }

        private void summaryOfResidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(APARTMENT.Furnished) AS 'Count of Furnished Aparments' FROM RESIDENT " +
                "JOIN APARTMENT ON RESIDENT.Resident_ID = APARTMENT.Resident_ID WHERE APARTMENT.Furnished = 1; ";
            GenericReportForm fullForm = new GenericReportForm(query, "Summary Report Of Amount of Furnished Apartments");
            fullForm.ShowDialog();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNewResident newresident = new FormAddNewResident();
            newresident.ShowDialog();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRemoveResident removeresident = new FormRemoveResident();
            removeresident.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditResident editresident = new FormEditResident();
            editresident.ShowDialog();
        }
    }
}
