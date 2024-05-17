using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_and_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define an initial max and min numbers
            int max = int.MinValue;
            int min = int.MaxValue;

            // Repeat 10 times
            for (int i = 1; i <=10; i++)
            {
                // Get a number from user
                Console.WriteLine("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                // Check if number is bigger than the current max
                if (num > max)
                {
                    max = num;
                }
                // Otherwise - check if the number is smaller than the current min
                else
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
            }
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
        }
    }
}
