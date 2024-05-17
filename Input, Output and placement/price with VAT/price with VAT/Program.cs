using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace price_with_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter product price: ");
            double price = double.Parse(Console.ReadLine());

            double total = price + 0.18 * price;

            Console.WriteLine("Total price: " + total);
        }
    }
}
