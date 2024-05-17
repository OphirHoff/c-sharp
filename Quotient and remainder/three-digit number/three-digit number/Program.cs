using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three_digit_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a three-digit number: ");
            // get a three-digit-number from the user
            int num = int.Parse(Console.ReadLine());

            // units of the number
            int units = num % 10;
            // hundreds
            int hundreds = num / 100;
            // dozens
            int dozens = (num - (hundreds * 100) - units) / 10;
            // multiplication of the units, dozens and hundreds.
            int multiplication = units * dozens * hundreds;

            Console.WriteLine($"Units: {units}");
            Console.WriteLine($"Dozens: {dozens}");
            Console.WriteLine($"Hundreds: {hundreds}");
            Console.WriteLine($"Multiplication: {multiplication}");
        }
    }
}
