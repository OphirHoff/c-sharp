using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_divisible_by_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            while (num != -10)
            {
                if ((num % 10) % 5 == 0)
                {
                    Console.WriteLine((num % 10) + 2);
                }

                else
                {
                    Console.WriteLine(num % 10);
                }

                Console.WriteLine("Enter a number");
                num = int.Parse(Console.ReadLine());

            }
        }
    }
}
