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
    public partial class FormEditResident : Form
    {
        public FormEditResident()
        {
            InitializeComponent();
        }
        public SqlConnection conn = new SqlConnection(@"Data Source=ec2-18-224-139-30.us-east-2.compute.amazonaws.com;User ID=Johns;Password=adminUser1!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlCommand comm;
        public SqlDataAdapter adapter;
        public SqlDataReader dReader;
        public DataSet ds;
        public String branchcode, bank;
        public int bankID;

        private void FormEditResident_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            epName.SetError(tbName, ""); //reset all error providers
            epSurname.SetError(tbSurname, "");
            epCell.SetError(tbCell, "");
            epID.SetError(tbID, "");
            epBranch.SetError(tbBranch, "");
            epAccNum.SetError(tbAccNum, "");

            if (tbName.Text == string.Empty) //Validate all fields
            {
                epName.SetError(tbName, "Please enter a name!");
            }
            else if (tbSurname.Text == string.Empty)
            {
                epSurname.SetError(tbSurname, "Please enter a surname!");
            }
            else if (tbCell.Text == string.Empty)
            {
                epCell.SetError(tbCell, "Please enter a cellphone number!");
            }
            else if (tbID.Text == string.Empty)
            {
                epID.SetError(tbID, "Please enter an ID number!");
            }
            else if (tbBranch.Text == string.Empty)
            {
                epBranch.SetError(tbBranch, "Please enter a branch code!");
            }
            else if (tbAccNum.Text == string.Empty)
            {
                epAccNum.SetError(tbAccNum, "Please enter an Account number!");
            }
            else
            {
                try
                {
                    conn.Open(); // Enter resident details into database
                    bank = tbBranch.Text;

                    if (bank == "Nedbank")
                    {
                        bankID = 1;
                        branchcode = "198765";
                    }
                    else if (bank == "Standard Bank")
                    {
                        bankID = 3;
                        branchcode = "200109";
                    }
                    else if (bank == "ABSA")
                    {
                        bankID = 4;
                        branchcode = "198765";
                    }
                    else if (bank == "First Rand Bank")
                    {
                        bankID = 5;
                        branchcode = "632005";
                    }
                    else if (bank == "Bidvest Bank")
                    {
                        bankID = 6;
                        branchcode = "250655";
                    }
                    else if (bank == "Investec Bank")
                    {
                        bankID = 7;
                        branchcode = "470010";
                    }
                    else if (bank == "Capitec")
                    {
                        bankID = 8;
                        branchcode = "580105";
                    }
                    else if (bank == "African Bank")
                    {
                        bankID = 9;
                        branchcode = "580105";
                    }
                    else if (bank == "Discovery Bank")
                    {
                        bankID = 10;
                        branchcode = "580105";
                    }

                    SqlCommand sqlinsert = new SqlCommand("UPDATE dbo.RESIDENT SET First_Name=@name, Last_Name=@surname, Cell_Number=@cellnum, Bank_ID=@bankID, ID_Number=@id, Branch_Code=@branchcode, Account_Number=@AccNum WHERE ID_Number=@id2", conn);
                    sqlinsert.Parameters.AddWithValue("@name", tbName.Text ?? (object)DBNull.Value);
                    sqlinsert.Parameters.AddWithValue("@surname", tbSurname.Text ?? (object)DBNull.Value);
                    sqlinsert.Parameters.AddWithValue("@cellnum", tbCell.Text ?? (object)DBNull.Value);
                    sqlinsert.Parameters.AddWithValue("@id", tbID.Text ?? (object)DBNull.Value);
                    sqlinsert.Parameters.AddWithValue("@AccNum", tbAccNum.Text ?? (object)DBNull.Value);
                    sqlinsert.Parameters.AddWithValue("@branchcode", tbBranch.Text ?? (object)DBNull.Value);
                    sqlinsert.Parameters.AddWithValue("@bankID", bankID);
                    sqlinsert.Parameters.AddWithValue("@id2", tbID.Text ?? (object)DBNull.Value);

                    adapter = new SqlDataAdapter();

                    adapter.InsertCommand = sqlinsert;
                    adapter.InsertCommand.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Resident Successfully Updated");  //Display message
                    this.Close();  //close form
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
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
