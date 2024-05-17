using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible_by_3_and_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            while (num != -1)
            {
                if (num % 4 == 0 && num % 3 == 0)
                {
                    count++;
                }

                Console.WriteLine("Enter a number");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{count} numbers are divisible by 4 and 3");
        }
    }
}
