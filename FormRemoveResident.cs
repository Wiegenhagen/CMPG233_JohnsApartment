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
    public partial class FormRemoveResident : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=ec2-18-224-139-30.us-east-2.compute.amazonaws.com;User ID=Johns;Password=adminUser1!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlCommand comm;
        public SqlDataAdapter adapter;
        public SqlDataReader dReader;
        public DataSet ds;
        public String idnum;
        public FormRemoveResident()
        {
            InitializeComponent();
        }

        private void FormRemoveResident_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                idnum = tbID.Text;

                conn.Open();

                SqlCommand sqlinsert = new SqlCommand($"DELETE FROM RESIDENT WHERE ID_Number = '{idnum}'", conn);
                adapter = new SqlDataAdapter();

                adapter.InsertCommand = sqlinsert;
                adapter.InsertCommand.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Resident Successfully Removed");  //Display message
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadAll()
        {
            try
            {
                conn.Open();

                SqlCommand comm = new SqlCommand("SELECT * FROM RESIDENT", conn);

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                adapter.SelectCommand = comm;
                adapter.Fill(ds, "SourceTable");

                dgvResidents.DataSource = ds;
                dgvResidents.DataMember = "SourceTable";
                conn.Close();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
