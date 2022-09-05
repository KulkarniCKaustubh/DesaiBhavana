using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;

namespace HRAppl
{
    public class Program
    {
        static void Main(string[] args)
        {
            string choice, num;

            List<ConfirmEmployee> empList = new List<ConfirmEmployee>();
            empList.Add(new ConfirmEmployee { Name = "KK", Address = "DN DR Akola", TypeEmployee = "Trainee", Basic = 21000, Designation = "Sofware Developer" });
            empList.Add(new ConfirmEmployee { Name = "SK", Address = "Pune", TypeEmployee = "Developer", Basic = 25000, Designation = "Tester" });



            List<Trainee> trainee = new List<Trainee>();
            trainee.Add(new Trainee { Name = "Kaustubh", Address = "Akola", TypeEmployee = "Trainee" });
            trainee.Add(new Trainee { Name = "Shri", Address = "Pune", TypeEmployee = "Trainee" });

            do
            {
                int num1 = 0;
                Console.WriteLine("1. Show All Employees");
                Console.WriteLine("2. Show Employee which you want");
                Console.WriteLine();
                Console.WriteLine("Enter a number from above choice");
                int result = int.Parse(Console.ReadLine());

                if (result == 1)
                {
                    foreach (ConfirmEmployee empno in empList)
                    {
                        Console.WriteLine(empno);
                    }
                    foreach (Trainee empno in trainee)
                    {
                        Console.WriteLine(empno);
                    }
                }
                else if (result == 2)
                {
                    Console.WriteLine("Enter a Employee Number which you want : ");
                    num = Console.ReadLine();

                    foreach (ConfirmEmployee empno in empList)
                    {
                        if (empno.EmpNo == num)
                        {
                            Console.WriteLine(empno);
                            num1++;
                            break;
                        }
                    }

                    foreach (Trainee empno1 in trainee)
                    {
                        if (empno1.EmpNo == num)
                        {
                            Console.WriteLine(empno1);
                            num1++;
                            break;
                        }
                    }

                    if (num1 == 0)
                    {
                        Console.WriteLine("Employe Not Found");
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Do you Want to Continue Press 'y' or 'n' :");
                choice = Console.ReadLine();

            } while (choice == "y");

            Console.ReadLine();
        }
    }
}
