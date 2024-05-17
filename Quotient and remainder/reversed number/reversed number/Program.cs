using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversed_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a two-digit number: ");
            // get a two-digit number from the user
            int num = int.Parse(Console.ReadLine());

            // units of the number
            int units = num % 10;
            // dozens of the number
            int dozens = num / 10;

            Console.WriteLine(units + "" + dozens);

        }
    }
}
