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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection conn = Connect();
        }

        public SqlConnection Connect()
        { 
            //Verander die Data Source = na julle PC se naam, kyk wat julle connection string is. Data Source=""DESKTOP-LNM37V2 <--- verander die"
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LNM37V2;Initial Catalog=JOHNS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;User ID=johnsSystem;Password=password;"));
            return conn;
        }
    }
}
