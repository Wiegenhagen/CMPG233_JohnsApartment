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
        public String name, surname, cellnum, id, bank, AccNum, branchcode;
        public int contract = 0, bankID;

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
    }
}
