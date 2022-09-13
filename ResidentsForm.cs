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
    public partial class ResidentsForm : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=ec2-18-224-139-30.us-east-2.compute.amazonaws.com;User ID=Johns;Password=adminUser1!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlDataAdapter adapter;
        public SqlDataReader dReader;
        public SqlCommand comm;
        public DataSet ds;
        public String name, surname, cellnum, id, bank, AccNum, branchcode;
        public int contract = 0, bankID;
        public String idnum;
        public int bankID2;
        public String branchcode2, bank2;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            loadAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            epName1.SetError(tbName, ""); //reset all error providers
            epSurname1.SetError(tbSurname, "");
            epCell1.SetError(tbCell, "");
            epID1.SetError(tbID, "");
            epBranch1.SetError(tbBranch, "");
            epAccNum1.SetError(tbAccNum, "");

            if (tbName2.Text == string.Empty) //Validate all fields
            {
                epName.SetError(tbName, "Please enter a name!");
            }
            else if (tbSurname2.Text == string.Empty)
            {
                epSurname.SetError(tbSurname, "Please enter a surname!");
            }
            else if (tbCell2.Text == string.Empty)
            {
                epCell.SetError(tbCell, "Please enter a cellphone number!");
            }
            else if (tbID2.Text == string.Empty)
            {
                epID.SetError(tbID, "Please enter an ID number!");
            }
            else if (tbBranch2.Text == string.Empty)
            {
                epBranch.SetError(tbBranch, "Please enter a branch code!");
            }
            else if (tbAccNum2.Text == string.Empty)
            {
                epAccNum.SetError(tbAccNum, "Please enter an Account number!");
            }
            else
            {
                try
                {
                    conn.Open(); // Enter resident details into database
                    bank2 = tbBranch2.Text;

                    if (bank2 == "Nedbank")
                    {
                        bankID2 = 1;
                        branchcode2 = "198765";
                    }
                    else if (bank2 == "Standard Bank")
                    {
                        bankID2 = 3;
                        branchcode2 = "200109";
                    }
                    else if (bank2 == "ABSA")
                    {
                        bankID2 = 4;
                        branchcode2 = "198765";
                    }
                    else if (bank2 == "First Rand Bank")
                    {
                        bankID2 = 5;
                        branchcode2 = "632005";
                    }
                    else if (bank2 == "Bidvest Bank")
                    {
                        bankID2 = 6;
                        branchcode2 = "250655";
                    }
                    else if (bank2 == "Investec Bank")
                    {
                        bankID2 = 7;
                        branchcode2 = "470010";
                    }
                    else if (bank2 == "Capitec")
                    {
                        bankID2 = 8;
                        branchcode2 = "580105";
                    }
                    else if (bank2 == "African Bank")
                    {
                        bankID2 = 9;
                        branchcode2 = "580105";
                    }
                    else if (bank2 == "Discovery Bank")
                    {
                        bankID2 = 10;
                        branchcode2 = "580105";
                    }

                    SqlCommand sqlinsert = new SqlCommand("UPDATE dbo.RESIDENT SET First_Name=@name, Last_Name=@surname, Cell_Number=@cellnum, Bank_ID=@bankID, ID_Number=@id, Branch_Code=@branchcode, Account_Number=@AccNum WHERE ID_Number=@id2", conn);
                    sqlinsert.Parameters.AddWithValue("@name", tbName2.Text ?? (object)DBNull.Value);
                    sqlinsert.Parameters.AddWithValue("@surname", tbSurname2.Text ?? (object)DBNull.Value);
                    sqlinsert.Parameters.AddWithValue("@cellnum", tbCell2.Text ?? (object)DBNull.Value);
                    sqlinsert.Parameters.AddWithValue("@id", tbID2.Text ?? (object)DBNull.Value);
                    sqlinsert.Parameters.AddWithValue("@AccNum", tbAccNum2.Text ?? (object)DBNull.Value);
                    sqlinsert.Parameters.AddWithValue("@branchcode", branchcode2 ?? (object)DBNull.Value);
                    sqlinsert.Parameters.AddWithValue("@bankID", bankID2);
                    sqlinsert.Parameters.AddWithValue("@id2", tbID2.Text ?? (object)DBNull.Value);

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

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            loadAll2();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewAll2_Click(object sender, EventArgs e)
        {
            loadAll2();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                idnum = tbID1.Text;

                conn.Open();

                SqlCommand sqlinsert = new SqlCommand($"DELETE FROM dbo.RESIDENT WHERE ID_Number = '{idnum}'", conn);
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

        public ResidentsForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                epBranch.SetError(tbBranch, "Please choose a bank!");
            }
            else if (tbAccNum.Text == string.Empty)
            {
                epAccNum.SetError(tbAccNum, "Please enter an Account number!");
            }
            else
            {
                try
                {
                    if (cbContract.Checked)
                    {
                        contract = 1;
                    }
                    else
                    {
                        contract = 0;
                    }

                    conn.Open(); // Enter resident details into database

                    name = tbName.Text;
                    surname = tbSurname.Text;
                    cellnum = tbCell.Text;
                    id = tbID.Text;
                    bank = tbBranch.Text;
                    AccNum = tbAccNum.Text;

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

                    SqlCommand sqlinsert = new SqlCommand($"INSERT INTO dbo.RESIDENT (First_Name, Last_Name, Cell_Number, ID_Number, Branch_Code, Account_Number, Acknowlegde_Contract, Bank_ID) VALUES ('{name}','{surname}','{cellnum}','{id}','{branchcode}','{AccNum}','{contract}', {bankID})", conn);
                    adapter = new SqlDataAdapter();

                    adapter.InsertCommand = sqlinsert;
                    adapter.InsertCommand.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Resident Successfully Added");  //Display message
                    this.Close();  //close form
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
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

                SqlCommand comm = new SqlCommand("SELECT * FROM dbo.RESIDENT", conn);

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
        private void loadAll2()
        {
            try
            {
                conn.Open();

                SqlCommand comm = new SqlCommand("SELECT * FROM dbo.RESIDENT", conn);

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                adapter.SelectCommand = comm;
                adapter.Fill(ds, "SourceTable");

                dgvResidents2.DataSource = ds;
                dgvResidents2.DataMember = "SourceTable";
                conn.Close();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
