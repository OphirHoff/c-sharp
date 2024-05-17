using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get number from user
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            // repeat on each number from 2 to input num
            for (int x = 2; x <= num; x++)
            {
                bool is_prime = true; // stoping condition

                // repeat on every sub-number as long it has no dividers
                for (int i = 2; i < x && is_prime == true; i++)
                {
                    if (x % i == 0)
                    {
                        is_prime = false;
                    }
                }
                if (is_prime == true)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
