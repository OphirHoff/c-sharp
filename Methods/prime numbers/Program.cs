using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    class Program
    {
        public static bool Prime (int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            if (Prime(num))
            {
                Console.WriteLine("This number is prime");
            }
            else
            {
                Console.WriteLine("This number is NOT prime");
            }
        }
    }
}
