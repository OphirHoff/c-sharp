using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numebrs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                bool is_prime = true;
                for (int i = 2; i < num && is_prime; i++)
                {
                    if (num % i == 0)
                    {
                        is_prime = false;
                    }
                }

                if (is_prime)
                {
                    Console.WriteLine(num + " is prime");
                }

                Console.WriteLine("Enter a number");
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
