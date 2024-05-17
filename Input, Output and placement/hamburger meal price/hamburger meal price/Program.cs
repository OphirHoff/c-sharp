using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamburger_meal_price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the price of a hamburger?");
            double ham_price = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the price of a coke?");
            double coke_price = double.Parse(Console.ReadLine());

            double total = ham_price + coke_price;
            Console.WriteLine("total: " + total);

        }
    }
}
