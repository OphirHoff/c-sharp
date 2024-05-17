using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_many_negative_and_positive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Positive numbers counter
            int negative = 0;
            // Negative numbers counter
            int positive = 0;

            // Repeat 10 times
            for (int i = 1; i <=10; i++)
            {
                // Get number from user
                Console.WriteLine("Enter number: ");
                int num = int.Parse(Console.ReadLine());

                // Check if number is positive or negative
                if (num > 0)
                    positive += 1;
                else if (num < 0)
                    negative += 1;

            }
            Console.WriteLine($"Positive: {positive}, negative: {negative}");

        }
    }
}
