using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three_digit_numbers_couples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            while (!(num1 == 100 && num2 == 100))
            {
                int sum_num1 = ((num1 / 10) % 10) + (num1 % 10);
                int sum_num2 = ((num2 / 10) % 10) + (num2 % 10);

                if (sum_num1 > sum_num2)
                {
                    Console.WriteLine(num1);
                }

                else if (sum_num2 > sum_num1)
                {
                    Console.WriteLine(num2);
                }

                Console.WriteLine("Enter first number");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number");
                num2 = int.Parse(Console.ReadLine());

            }

        }
    }
}
