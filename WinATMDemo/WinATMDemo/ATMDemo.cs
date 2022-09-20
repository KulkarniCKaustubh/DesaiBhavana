using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using ATMDataAccessLibrary;

namespace WinATMDemo
{
    
    public partial class ATMDemo : Form
    {
        CustomerData datastore;
        public ATMDemo()
        {
            InitializeComponent();
            
           CustomerData dataStore = new CustomerData(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void ATMDemo_Load(object sender, EventArgs e)
        {

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

            //Parameterized query
            string sql = "Select * from carddetails where cardnumber = @cno and pin = @pin ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            
            command.Parameters.AddWithValue("cno", txtCardNo.Text);
            command.Parameters.AddWithValue("pin", txtPin.Text);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            if ((table.Rows.Count) > 0)
            {
                DataRow row = table.Rows[0];
               
                ATMEnter enter = new ATMEnter();  //nevigation
                enter.Show();
                
                MessageBox.Show("Welcome = " + row["CustomerName"].ToString());
            }
            else
            {
                MessageBox.Show("Please Enter Valid Details");
            }

        }
        void ClearTextBoxes()
        {
            txtCardNo.Clear();
            txtPin.Clear();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}




#region reference code
//try
//{
//   Customer customer = new Customer();
//    if (txtCardNo.Text = customer.CardNo &&  txtPin.Text = customer.Pin)
//    {
//        MessageBox.Show(customer.CustomerName);

//    }
//}
//catch (Exception)
//{

//    throw;
//}


// enter.ShowDialog();            //navigation

// dataGridView1.DataSource = table;

//if (table.Rows.Count == 0)
//{
//    MessageBox.Show("No data Found ");
//}
#endregion