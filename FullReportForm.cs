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
    public partial class FullReportForm : Form
    {
        public FullReportForm()
        {
            InitializeComponent();
            conn = new SqlConnection(conStr);//define connection
            //First Database
            conn.Open();//connection open
            string sql1 = "SELECT * FROM APARTMENT";

            comm = new SqlCommand(sql1, conn);//Command database to show
            theReader = comm.ExecuteReader();
            while (theReader.Read())
            {
                lstbxApartment.Items.Add(theReader.GetValue(4).ToString() + "\t\t" + theReader.GetValue(2).ToString() + "\t" + theReader.GetValue(3).ToString());
            }
            conn.Close();//connection close
            //Second Database
            conn.Open();//connection open
            string sql2 = "SELECT * FROM RESIDENT";

            comm = new SqlCommand(sql2, conn);//Command database to show
            theReader = comm.ExecuteReader();
            while (theReader.Read())
            {
                lstbxResident.Items.Add(theReader.GetValue(5).ToString() + "\t" + theReader.GetValue(2).ToString() + " " + theReader.GetValue(3).ToString() + "\t" + theReader.GetValue(4).ToString() + "\t" + theReader.GetValue(8).ToString() + "\t\t\t" + theReader.GetValue(7).ToString() + "\t" + theReader.GetValue(6).ToString());
                lstbxTemp.Items.Add(theReader.GetValue(1));
            }
            conn.Close();//connection close
            //Third Database
            conn.Open();//connection open
            string sql3 = "SELECT * FROM BANK";

            comm = new SqlCommand(sql3, conn);//Command database to show
            theReader = comm.ExecuteReader();
            while (theReader.Read())
            {
                lstbxBank.Items.Add(theReader.GetValue(0));
                lstbxTemp2.Items.Add(theReader.GetValue(1));
            }
            conn.Close();//connection close
            for (int i = 0; i < lstbxTemp.Items.Count; i++)
            {
                for(int j = 0; j < lstbxBank.Items.Count; j++)
                {
                    if (lstbxTemp.Items[i].ToString() == lstbxBank.Items[j].ToString())
                    {
                        lstbxBankResult.Items.Add(lstbxTemp2.Items[j]);
                    }
                }
            }
        }

        string conStr = @"Data Source=ec2-18-224-139-30.us-east-2.compute.amazonaws.com;User ID=Johns;Password=adminUser1!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader theReader;

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstbxFullReport.Items.Clear();
            lstbxFullReport.Items.Add("Apartment No\tOccupation Date\t\tFurnished\tResident ID\tResident Name\tCell No\t\tAcknowlegde Contact\tAccount No\tBranch No\tBank Name");
            lstbxFullReport.Items.Add("===================================================================================================================================================================================");
            for (int i = 0; i < lstbxApartment.Items.Count; i++)
            {
                lstbxFullReport.Items.Add(lstbxApartment.Items[i] + "\t\t" + lstbxResident.Items[i] +"\t\t" + lstbxBankResult.Items[i]);
            }

            btnSave.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lstbxApartment.Items.Clear();
            lstbxBank.Items.Clear();
            lstbxResident.Items.Clear();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string myfile;
            saveFDFull.InitialDirectory = @"c:\";
            if (saveFDFull.ShowDialog() == DialogResult.OK)
            {
                myfile = saveFDFull.FileName;
                StreamWriter output = File.CreateText(myfile);
                output.WriteLine("\t\t\t\t\t\t\t\t\tFull Report of JohnsApartments\n");
                for (int i = 0; i < lstbxFullReport.Items.Count; i++)
                {
                    output.WriteLine((string)lstbxFullReport.Items[i]);
                }
                output.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tReport was pulled on: " + DateTime.Now);
                output.Close();

            }
        }
    }
}
