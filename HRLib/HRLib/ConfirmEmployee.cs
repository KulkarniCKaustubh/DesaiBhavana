using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class ConfirmEmployee  : Employee
    {
        private double basic;
        public double Basic
        {
            get { return basic; }
            set { basic = value; }
        }

        private string designation;
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public ConfirmEmployee()
        {
            Basic = 30000;
            Designation = "Trinee";

        }

        public ConfirmEmployee(string name, string address, double basic, string designation) : base(name, address)
        {
            Basic = basic;
            Designation = designation;
        }

        public override string ToString()
        {
            return String.Format($" BAsic : {basic} Designation : {designation}");
        }

        public override double CalculateSalary()
        {
            double hra, conv, pf, netSalary;

            if (Basic >= 30000)
            {
                hra = Basic * 0.3;
                conv = Basic * 0.3;
                pf = Basic * 0.3;
            }

            else if (Basic >= 20000)
            {
                hra = Basic * 0.2;
                conv = Basic * 0.2;
                pf = Basic * 0.2;
            }



            else
            {
                hra = Basic * 0.1;
                conv = Basic * 0.1;
                pf = Basic * 0.1;
            }



            netSalary = Basic + hra + conv - pf;
            return netSalary;



        }
    }
}

