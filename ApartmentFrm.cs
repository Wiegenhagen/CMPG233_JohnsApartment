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
    public partial class ApartmentFrm : Form
    {
        public ApartmentFrm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ec2-18-224-139-30.us-east-2.compute.amazonaws.com;User ID=Johns;Password=adminUser1!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter adapter;
        SqlDataReader reader;

        private void ApartmentFrm_Load(object sender, EventArgs e)
        {
            loadResComboBox();
            loadAprtIDComboBox();
            loadUpdateResComboBox();
            loadDeletAprtIDComboBox();
        }
        public Boolean furnished;
        private void AddApartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String ResIDNm = cbResName.SelectedIndex.ToString();
                String OccuDate = OccupationCal.SelectionRange.Start.ToString("yyyy-MM-dd");
                if (rbYes.Checked)
                {
                    furnished = true;
                }
                if (rbNo.Checked)
                {
                    furnished = false;
                }
                int ApartNumber = Convert.ToInt32(ApartNumtxt.Text);

                con.Open();
                SqlCommand comm = new SqlCommand($"INSERT INTO dbo.APARTMENT(Resident_ID, Occupation_Date, Furnished, Apartment_Number) VALUES({ResIDNm}, '{OccuDate}', '{furnished}', {ApartNumber})", con);

                adapter = new SqlDataAdapter();

                adapter.InsertCommand = comm;
                adapter.InsertCommand.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            this.Close();

        }
        private void UpdateAprtbtn_Click(object sender, EventArgs e)
        {
            try
            {

                String AprtNom = UpdateAprtcb.Text;
                String ResIDNm = UpdateRescb.SelectedIndex.ToString();
                String OccuDate = UpdateCal.SelectionRange.Start.ToString("yyyy-MM-dd");
                if (rbUpdateYes.Checked)
                {
                    furnished = true;
                }
                if (rbUpdateNo.Checked)
                {
                    furnished = false;
                }
                int ApartNumber = Convert.ToInt32(UpdateAprtNumtxt.Text);
                con.Open();
                SqlCommand comm = new SqlCommand("UPDATE dbo.APARTMENT SET Resident_ID = @ResID, Occupation_Date = @OccuDate, Furnished = @Furn, Apartment_Number = @AprtNum WHERE Apartment_Number = @AprtNm", con);
                comm.Parameters.AddWithValue("@AprtNm", AprtNom);
                comm.Parameters.AddWithValue("@ResID", ResIDNm);
                comm.Parameters.AddWithValue("@OccuDate", OccuDate);
                comm.Parameters.AddWithValue("@Furn", furnished);
                comm.Parameters.AddWithValue("AprtNum", ApartNumber);
                comm.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            this.Close();
        }
        private void DeleteAprtbtn_Click(object sender, EventArgs e)
        {
            try
            {
                String AprtNm = DeleteAprtcb.Text;
                con.Open();
                SqlCommand comm = new SqlCommand("DELETE FROM dbo.APARTMENT WHERE Apartment_Number = @AprtNm", con);
                comm.Parameters.AddWithValue("@AprtNm", AprtNm);
                comm.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }


            loadDeletAprtIDComboBox();
            this.Close();
        }
        private void loadResComboBox()
        {
            try
            {
                con.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM RESIDENT", con);
                reader = comm.ExecuteReader();
                cbResName.Items.Clear();
                cbResName.Items.Add("ID Number");

                while (reader.Read())
                {
                    cbResName.Items.Add(reader.GetValue(5));
                }

                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }
        private void loadUpdateResComboBox()
        {
            try
            {
                con.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM dbo.RESIDENT", con);
                reader = comm.ExecuteReader();
                UpdateRescb.Items.Clear();
                UpdateRescb.Items.Add("ID Number");

                while (reader.Read())
                {
                    UpdateRescb.Items.Add(reader.GetValue(5));
                }

                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }
        private void loadAprtIDComboBox()
        {
            try
            {
                con.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM dbo.APARTMENT", con);
                reader = comm.ExecuteReader();
                UpdateAprtcb.Items.Clear();
                UpdateAprtcb.Items.Add("Apartment Number");

                while (reader.Read())
                {
                    UpdateAprtcb.Items.Add(reader.GetValue(4));
                }

                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }
        private void loadDeletAprtIDComboBox()
        {
            try
            {
                con.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM dbo.APARTMENT", con);
                reader = comm.ExecuteReader();
                DeleteAprtcb.Items.Clear();
                DeleteAprtcb.Items.Add("Apartment Number");

                while (reader.Read())
                {
                    DeleteAprtcb.Items.Add(reader.GetValue(4));
                }

                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }

        }

        private void Exitbtn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exitbtn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exitbtn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
