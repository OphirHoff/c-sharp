using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_couples
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            // Repeat 20 times
            for (int i = 1; i <= 20; i++)
            {
                // Get first number from user
                Console.Write("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());

                // Get second number from user
                Console.Write("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                // Check if both numbers meets the conditions
                if((num1 > 0 && num2 > 0) && (num1 % 2 !=0 && num2 % 2 != 0))
                {
                    // Add both number to sum
                    sum += num1 + num2;
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
