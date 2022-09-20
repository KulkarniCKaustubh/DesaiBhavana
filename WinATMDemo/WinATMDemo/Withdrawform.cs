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
using ATMDataAccessLibrary;
using System.Configuration;

namespace WinATMDemo
{
	public partial class Withdrawform : Form
	{
		CustomerData datastore;

		public Withdrawform()
		{
			InitializeComponent();

			CustomerData dataStore = new CustomerData(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
		}


		DataTable table = new DataTable();
		string sql = "SELECT * FROM Accinfo where  accno = " ;

		//if (table.Rows.Count > 0)
		//{
		//AccBal = (string)(table.Rows[0]["AccBal"]);
		//			num1 = int.Parse(balance);
		//			num2 = int.Parse(txtamount.Text);

		//			if (num2 > 25000)
		//			{
		//				MessageBox.Show("You can Only Withdraw Php 25,000");
		//			}
		//			else if (num2 < 200)
		//			{
		//				MessageBox.Show(" Mininum withdrawal is 200");
		//			}
		//			else if (num1 < num2)
		//			{
		//				MessageBox.Show(" Insuffiecient balance");

		//			}
		//			else
		//			{
		//				total = num1 - num2;


		//				//MsgBox("success")

		//				this.Hide();


		//			}
		//	    }
		//		else
		//		{


		//		}
		//	}
		//		catch (Exception)
		//		{
		//			MessageBox.Show(" Pls. Enter Ammount!");
		//			//MsgBox(ex.Message)
		//		}
		//      txtamount.Text = "";


	}
}

