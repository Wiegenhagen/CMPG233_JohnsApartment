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
using System.IO;

namespace Group_26_Johns_RealEstate_Management_System
{
    public partial class ResidentsReportForm : Form
    {
        public ResidentsReportForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string conStr = @"Data Source=ec2-18-224-139-30.us-east-2.compute.amazonaws.com;User ID=Johns;Password=adminUser1!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader theReader;

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnYes.Checked)
            {
                lstbxResidents.Items.Clear();
                conn = new SqlConnection(conStr);//define connection
                conn.Open();//connection open
                string sql = "SELECT * FROM RESIDENT ORDER BY Last_Name ASC";

                comm = new SqlCommand(sql, conn);//Command database to show
                theReader = comm.ExecuteReader();
                lstbxResidents.Items.Add("ID Number" + "\t" + "Resident Name" + "\t\t" + "Cell Number" + "\t" + "Account Number" + "\t" + "Branch Number");
                lstbxResidents.Items.Add("===========================================================================================================");
                while (theReader.Read())
                {
                    lstbxResidents.Items.Add(theReader.GetValue(5) + "\t" + theReader.GetValue(2) + " " + theReader.GetValue(3) + "\t\t" + theReader.GetValue(4) + "\t" + theReader.GetValue(7) + "\t" + theReader.GetValue(6));
                }
            }
            else
            {
                lstbxResidents.Items.Clear();
                conn = new SqlConnection(conStr);//define connection
                conn.Open();//connection open
                string sql = "SELECT * FROM RESIDENT";

                comm = new SqlCommand(sql, conn);//Command database to show
                theReader = comm.ExecuteReader();
                lstbxResidents.Items.Add("ID Number" + "\t" + "Resident Name" + "\t\t" + "Cell Number" + "\t" + "Account Number" + "\t" + "Branch Number");
                lstbxResidents.Items.Add("=================================================================================================================");
                while (theReader.Read())
                {
                    lstbxResidents.Items.Add(theReader.GetValue(5) + "\t" + theReader.GetValue(2) + " " + theReader.GetValue(3) + "\t\t" + theReader.GetValue(4) + "\t" + theReader.GetValue(7) + "\t" + theReader.GetValue(6));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myfile;
            saveFDResidents.InitialDirectory = @"c:\";
            if (saveFDResidents.ShowDialog() == DialogResult.OK)
            {
                myfile = saveFDResidents.FileName;
                StreamWriter output = File.CreateText(myfile);
                output.WriteLine("\t\t\t\tReport of Residents\n");
                for (int i = 0; i < lstbxResidents.Items.Count; i++)
                {
                    output.WriteLine((string)lstbxResidents.Items[i]);
                }
                output.WriteLine("\n\n\t\t\tReport was pulled on: " + DateTime.Now);
                output.Close();

            }
        }
    }
}
