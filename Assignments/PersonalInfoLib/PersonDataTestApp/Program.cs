using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalInfoLib;

namespace PersonDataTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Kaustubh", "Kulkarni", "KK@email.com", Convert.ToDateTime("24/12/1999"));
            Console.WriteLine(p1);

            Console.WriteLine("Is Person is Adult " + p1.IsAdult());

            Console.ReadLine();
        }
    }
}
