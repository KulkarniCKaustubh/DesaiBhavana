using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonaccySeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;



            int y = 1;



            int z = 1;

            while (x <= 100)
            {
                z = x + y;
                x = y;
                y = z;
                Console.WriteLine(y);
            }
            Console.ReadLine();
        }
        }
    }

