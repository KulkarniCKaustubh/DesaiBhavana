using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int number1, number2, temp;
                Console.WriteLine("\nInput the First Number : ");
                number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nInput the Second Number : ");
                number2 = int.Parse(Console.ReadLine());
                temp = number1;
                number1 = number2;
                number2 = temp;
                Console.WriteLine("\nAfter Swapping : ");
                Console.WriteLine("\nFirst Number : " + number1);
                Console.WriteLine("\nSecond Number : " + number2);
                Console.ReadLine();
            }
        }
    }
}
