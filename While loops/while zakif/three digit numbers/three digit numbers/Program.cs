using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three_digit_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;

            Console.WriteLine("Enter a three-digit number");
            int num = int.Parse(Console.ReadLine());

            while (num > 99 && num < 1000)
            {
                if (num % 10 > num / 100)
                {
                    sum += num;
                }

                if (((num / 10) % 10) % 2 == 0 && (num / 100) % 2 != 0)
                {
                    count++;
                }

                Console.WriteLine("Enter a three-digit number");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
            Console.WriteLine(count);
        }   
    }
}
