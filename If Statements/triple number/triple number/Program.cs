using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triple_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a two-digit number: ");
            // Get a two-digit number from user
            int num = int.Parse(Console.ReadLine());

            // units
            int units = num % 10;

            // dozens
            int doznes = num / 10;

            // Check if number meets the conditions
            if (Math.Pow(units, 3) + Math.Pow(doznes, 3) == num)
                Console.WriteLine("This is a triple number");
            else
                Console.WriteLine("This is NOT a triple number");
        }
    }
}
