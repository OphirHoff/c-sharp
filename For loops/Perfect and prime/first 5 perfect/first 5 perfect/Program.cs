using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_5_perfect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get a number from user
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            // Prime numbers counter
            int prime = 0;

            // Repeat as long as there are no more than 5 prime numbers
            for (int x = 1; prime != 5 && x < num; x++)
            {
                int sum = 0;
                for (int i = 1; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == x)
                {
                    Console.WriteLine(x);
                    prime++;
                }
            }
        }
    }
}
