using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingLib;

namespace TestShopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("ABC", 100, 10);
           
            double cost = product.GetProductCost();

            Console.WriteLine("Total Cost of Product = " + cost);
            Console.WriteLine(product);

            Product p1 = new Product("XYZ", 100, 20);

            double Cost = p1.GetProductCost();
            Console.WriteLine(p1);
            Product p2 = new Product("MNO", 200, 25);
   
            double Cost2 = p2.GetProductCost();
            Console.WriteLine(p2); 
            Console.ReadLine();
        }
    }
}
