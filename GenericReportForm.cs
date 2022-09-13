using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Group_26_Johns_RealEstate_Management_System
{
    public partial class GenericReportForm : Form
    {
        string conStr = @"Data Source=ec2-18-224-139-30.us-east-2.compute.amazonaws.com;User ID=Johns;Password=adminUser1!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader reader;
        string query;

        public GenericReportForm(string query, string title)
        {
            InitializeComponent();
            conn = new SqlConnection(conStr);//define connection
            lblTitle.Text = title;
            this.query = query;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstbxFullReport.Items.Clear();

            conn.Open();//connection open

            comm = new SqlCommand(query, conn);//Command database to show
            reader = comm.ExecuteReader();

            string headerRow = "";
            string spaceRow = "";
            // Add headers and replace the _ with a space, and only add headers once
            for (int i = 0; i < reader.FieldCount; i++)
            {
                string temp = reader.GetName(i).ToString().Replace('_', ' ') + "\t";
                if (temp.Length < 10)
                {
                    temp += "\t";
                }
                headerRow += temp;
                spaceRow += "===================";
            }
            lstbxFullReport.Items.Add(headerRow);
            lstbxFullReport.Items.Add(spaceRow);
            while (reader.Read())
            {
                string row = "";
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string temp = reader.GetValue(i).ToString().Replace('_', ' ').Replace("00:00:00","") + "\t";
                    if (temp.Length < 10)
                    {
                        temp += "\t";
                    }
                    row += temp;
                }
                lstbxFullReport.Items.Add(row);
            }
            conn.Close();//connection close

            btnSave.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFDFull.InitialDirectory = @"c:\";
            if (saveFDFull.ShowDialog() == DialogResult.OK)
            {
                PdfWriter.WritePdf(saveFDFull.FileName, query, lblTitle.Text, conn, comm, reader);
            }
        }
    }
}
