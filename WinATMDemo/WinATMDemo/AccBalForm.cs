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
    public partial class AccBalForm : Form
    {

        public static AccBalForm instance;
        public Label lbl1;
        public AccBalForm()
        {
            InitializeComponent();
            instance = this;
            lblAccBal = lblAccBal;

        }
        public static string Balance;
        private void getbalance()
        {
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);



            connection.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select Balance from Transactions where cardNo=" + lblAccNo.Text, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblAccNo.Text = dt.Rows[0][0].ToString();
            connection.Close();


            //MySqlConnection connection;
            //MySqlCommand command;
            //MySqlDataReader reader;

            //public AccBalForm()
            //{
            //    InitializeComponent();
            //}

            //public string CustomerName { set => lblCustomerName.Text = value; }

            //public decimal AccBal { set => lblAccBal.Text = value.ToString(); }

            //public int AccNo { set => lblAccNo.Text = value.ToString(); }

            //public AccInfo GetAccountBalance(string CustomerName)
            //{
            //    CustomerData dataStore = new CustomerData(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

            //    Customer customer = new Customer();
            //    AccInfo account = new AccInfo();

            //    try
            //    {
            //        string sql = "Select  *  from Accinfo where CustomerName = @CustomerName and accno = @ano";
            //        MySqlCommand command = new MySqlCommand(sql, connection);

            //        command.Parameters.AddWithValue("CustomerName", lblCustomerName.Text);
            //        command.Parameters.AddWithValue("ano", lblAccNo.Text);

            //        if (connection.State == ConnectionState.Closed)
            //        {
            //            connection.Open();
            //        }

            //        MySqlDataReader reader = command.ExecuteReader();

            //        DataTable dt = new DataTable();
            //        dt.Load(reader);

            //        account.AccNo = Convert.ToInt32(dt.Rows[0]["AccNo"]);
            //        account.AccBal = Convert.ToDecimal(dt.Rows[0]["AccBal"]);

            //        customer.CustomerName = dt.Rows[0]["CustomerName"].ToString();


            //        #region TypeConversion 
            //        //employee.HireDate = reader["Hiredate"] as DateTime?;
            //        //employee.Sal = reader["Sal"] as decimal?;

            //        #endregion
            //        if ((dt.Rows.Count) > 0)
            //        {
            //            DataRow row = dt.Rows[0];
            //            AccBalForm accBalForm = new AccBalForm();
            //            accBalForm.Show(lblAccBal);

            //            MessageBox.Show("Welcome = " + row["AccBal"] + lblAccBal );
            //        }
            //        return account;
            //    }

            //    catch
            //    {
            //        throw;
            //    }
            //    finally
            //    {
            //        if (connection.State == ConnectionState.Open)
            //        {
            //            connection.Close();
            //        }
            //    }
            //}

        }
    }
}



#region accbal 
/* MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

 // Parameterized query
 string sql = "Select * from accinfo where accbal = @bal";
 MySqlCommand command = new MySqlCommand(sql, connection);
 command.Parameters.AddWithValue("bal", lblShowBal.Text);


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

     lblShowBal.Show();
 }*/
#endregion

