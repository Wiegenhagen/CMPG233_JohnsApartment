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
    public partial class FormAddNewResident : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=ec2-18-224-139-30.us-east-2.compute.amazonaws.com;User ID=Johns;Password=adminUser1!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlDataAdapter adapter;
        public SqlDataReader dReader;
        public SqlCommand comm;
        public String name, surname, cellnum, id, branchcode, AccNum, bankID;
        public int contract = 0;

        public FormAddNewResident()
        {
            InitializeComponent();
        }

        private void FormAddNewResident_Load(object sender, EventArgs e)
        {

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
                    branchcode = tbBranch.Text;
                    AccNum = tbAccNum.Text;

                    if (branchcode == "632005")
                    {
                        bankID = "4";
                    }
                    else if (branchcode == "250655")
                    {
                        bankID = "5";
                    }
                    else if (branchcode == "580105")
                    {
                        bankID = "7";
                    }

                    SqlCommand sqlinsert = new SqlCommand($"INSERT INTO RESIDENT (First_Name, Last_Name, Cell_Number, ID_Number, Branch_Code, Account_Number, Acknowlegde_Contract, Bank_ID) VALUES ('{name}','{surname}','{cellnum}','{id}','{branchcode}','{AccNum}','{contract}', '{bankID}')", conn);
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
    }
}
