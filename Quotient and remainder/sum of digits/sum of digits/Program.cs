using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a two-digit number: ");
            // get a two-digit-integer from the user
            int number = int.Parse(Console.ReadLine());

            // get the units and the dozens of the number
            int sum_digits = (number / 10) + (number % 10);

            Console.WriteLine($"The sum of digits is {sum_digits}");

        }
    }
}
