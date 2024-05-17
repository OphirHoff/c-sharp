using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_and_sum_of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            while (num != 1)
            {
                int digit_count = 0;
                int digits_sum = 0;

                while (num != 0)
                {
                    digits_sum += num % 10;
                    digit_count++;
                    num /= 10;
                }

                Console.WriteLine($"Number of digits: {digit_count}");
                Console.WriteLine($"Sum of digits: {digits_sum}");

                Console.WriteLine("Enter a number");
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
