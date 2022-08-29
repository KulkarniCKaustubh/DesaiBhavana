using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLib
{
    public class Product
    {
         private string productname;
        public string ProductName
            {
                get { return productname; }
                set { productname = value; }

            }

            private double price;
        public double Price 
        { 
            get { return price; }
            set { price = value; } 
        }

            private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double GetProductCost()
        {
           double Cost = Quantity * Price;
            return Cost;
        }

        public Product( string productName, double price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return String.Format($"ProductName {ProductName}, Price {Price} Quantity {Quantity} Cost {GetProductCost()}");
        }

    }
    }
