using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public abstract class Employee
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string typeemployee;

        public string TypeEmployee
        {
            get { return typeemployee; }
            set { typeemployee = value; }
        }

        public string EmpNo { get; set; }
        public Employee()
        {
            Name = "Kaustubh";
            Address = "Maharashtra";
        }
        public Employee(string name, string address)
        {
            Name = name;
            Address = address;
        }

          public override string ToString()
          {
            return String.Format($"Name {Name} Address {Address} EmpNo {EmpNo} ");
          }

        public abstract double CalculateSalary();

    
    }
}
