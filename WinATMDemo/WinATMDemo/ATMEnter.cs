using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMDataAccessLibrary;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WinATMDemo
{
    public partial class ATMEnter : Form
    {
        CustomerData datastore;
        
        string customerName;
        public string CustomerName { get => customerName; set => customerName = value; }

        public ATMEnter()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStatement_Click(object sender, EventArgs e)
        {
            MiniStatementForm miniStatementForm = new MiniStatementForm();
            miniStatementForm.ShowDialog();
        }

        private void btnCheckBal_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
           // CustomerData customer = new CustomerData();

           // var accInfo = datastore.GetAccountBalance(customerName);

            AccBalForm accBal = new AccBalForm();

            accBal.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdrawform withdrawform = new Withdrawform();
            withdrawform.Show();
        }
    }
}

