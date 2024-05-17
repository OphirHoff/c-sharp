using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_perfect_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get number from user
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            // Repeat on every number from 1 to the input number
            for (int x = 1; x <= num; x++)
            {
                // Sum of dividers
                int sum = 0;

                // Repeat on every sub-number
                for (int i = 1; i < x; i++)
                {
                
                    // Check if number divides by sub-number
                    if (x % i == 0)
                    {
                        sum += i;
                    }
                }

                // Check if sum of dividers equals to the number
                if (sum == x)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
