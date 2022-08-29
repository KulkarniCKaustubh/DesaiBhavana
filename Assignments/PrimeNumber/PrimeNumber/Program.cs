using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
  	        //Declaration  
                 bool isPrime = true;
                    int i, j;
                      //Calculate and display the Prime number  
              Console.WriteLine("Prime Numbers are : ");
                  for (i = 2; i <= 100; i++)
                {
                       for (j = 2; j <= 100; j++)
                    {
                                if (i != j && i % j == 0)
                        {
                            isPrime = false;
                                  break;
                                       }
                        }
                      if (isPrime)
                    {
                        Console.WriteLine("\t" + i);
                            }
                    isPrime = true;
                     }
                Console.ReadLine();

            }
        }
}
