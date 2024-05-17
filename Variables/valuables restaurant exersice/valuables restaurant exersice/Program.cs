using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuables_restaurant_exersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats the price of a business dish?");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("How many dishes were ordered?");
            int dishes_num = int.Parse(Console.ReadLine());

            double total = price * dishes_num;
            Console.WriteLine("total: " + total);


        }
    }
}
