using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_numbers_between
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            // Get first number from user
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            // Get second number from user
            int num2 = int.Parse(Console.ReadLine());

            // Define biggest and smallest number
            int max = Math.Max(num1, num2);
            int min = Math.Min(num1, num2);

            // Print all numbers between the two given numbers
            for (int i = min+1; i > min && i < max; i++)
                Console.WriteLine(i);

        }
    }
}
