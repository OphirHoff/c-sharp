using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            bool is_prime = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    is_prime = false;
                }
            }

            if (is_prime == true)
            {
                Console.WriteLine($"{num} is a prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number.");
            }
        }
    }
}
