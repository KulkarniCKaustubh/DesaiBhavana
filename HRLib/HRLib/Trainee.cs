using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Trainee : Employee
    {
        private int noofdays;
        public int NoOfDays
        {
            get { return noofdays; }
            set { noofdays = value; }
        }

        private double rateperday;
        public double RatePerDay
        {
            get { return rateperday; }
            set { rateperday = value; }
        }
        public Trainee()
        {
            noofdays = 15;
            rateperday = 1000;
        }

        public string EmpNo { get; set; }
        public Trainee(string name, string address, int noofday, double rateperday) : base(name, address)
        {
            NoOfDays = noofday;
            RatePerDay = rateperday;
        }
        public override string ToString()
        {
            return String.Format($"NoOfDays : {NoOfDays} RatePerDay : {RatePerDay}");
        }

        public override double CalculateSalary()
        {
            return NoOfDays + RatePerDay;
        }
    }
}
