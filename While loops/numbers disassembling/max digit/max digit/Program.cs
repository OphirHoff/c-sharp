using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            int max = 0;
            int digit = 1;
            int digit_max = 0;

            while (num > 0)
            {
                if (num % 10 > max)
                {
                    max = num % 10;
                    digit_max = digit;
                }

                num /= 10;
                digit++;
            }

            Console.WriteLine(digit_max);
        }
    }
}
