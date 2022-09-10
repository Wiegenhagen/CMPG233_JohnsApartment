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
    public partial class AparmentReportForm : Form
    {
        public AparmentReportForm()
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                lstbxApartReport.Items.Clear();
                lstbxApart.Items.Clear();
                lstbxRes.Items.Clear();
                conn = new SqlConnection(conStr);//define connection
                //First Database
                conn.Open();//connection open
                string sql = "SELECT * FROM APARTMENT";

                comm = new SqlCommand(sql, conn);//Command database to show
                theReader = comm.ExecuteReader();
                while (theReader.Read())
                {
                    lstbxApart.Items.Add(theReader.GetValue(4) + "\t\t" + theReader.GetValue(2).ToString() + "\t" + theReader.GetValue(3));
                }
                conn.Close();//connection close

                //Second database
                conn.Open();//connection open
                string sql_2 = "SELECT Resident_ID, First_Name, Last_Name FROM RESIDENT";
                comm = new SqlCommand(sql_2, conn);//Command database to show
                theReader = comm.ExecuteReader();
                while (theReader.Read())
                {
                    lstbxRes.Items.Add("  " + theReader.GetValue(0) + "\t\t" + theReader.GetValue(1) + " " + theReader.GetValue(2) + "\t");
                }
                conn.Close();//connection close

                lstbxApartReport.Items.Add("Resident ID" + "\t" + "Resident Name" + "\t" + "Apartmnet No" + "\t" + "Occupation Date" + "\t\t" + "Furnished");
                lstbxApartReport.Items.Add("===============================================================================================");


                for (int i = 0; i < lstbxApart.Items.Count; i++)
                {
                    lstbxApartReport.Items.Add((string)lstbxRes.Items[i] + "" + (string)lstbxApart.Items[i]);
                }
                btnSave.Enabled = true;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);//If error message will show
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string myfile;
            saveFDApartments.InitialDirectory = @"c:\";
            if (saveFDApartments.ShowDialog() == DialogResult.OK)
            {
                myfile = saveFDApartments.FileName;
                StreamWriter output = File.CreateText(myfile);
                output.WriteLine("\t\t\t\tReport of Appartments\n");
                for (int i = 0; i < lstbxApartReport.Items.Count; i++)
                {
                    output.WriteLine((string)lstbxApartReport.Items[i]);
                }
                output.WriteLine("\n\n\t\t\tReport was pulled on: " + DateTime.Now);
                output.Close();

            }
        }
    }
}
