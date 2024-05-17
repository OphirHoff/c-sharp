using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dollars_to_shekels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("current dollar rate: ");
            double rate = double.Parse(Console.ReadLine());

            Console.WriteLine("How many dollars so you have? ");
            double dollars = double.Parse(Console.ReadLine());

            double total_shekels = rate * dollars;

            Console.WriteLine("You have " + total_shekels + " Shekels");
        }
    }
}
