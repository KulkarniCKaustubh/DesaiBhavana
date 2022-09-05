using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;

namespace ABCCorp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConfirmEmployee confirmEmployee = new ConfirmEmployee("Kaustubh", "Akola", 25000, "trainee");
            Console.WriteLine(confirmEmployee);

            ConfirmEmployee confirmEmployee1 = new ConfirmEmployee();
            Console.WriteLine(confirmEmployee1);

            Trainee trainee = new Trainee("Kaustubh", "Akola", 15, 1500);
            Console.WriteLine(trainee);

            Console.WriteLine(trainee.CalculateSalary());

            Console.WriteLine(confirmEmployee1.CalculateSalary());

            Console.ReadLine();

        }
    }
}
