using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace all_equal_or_different
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool all_equal = true;

            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            int prev_dig = num % 10;

            while (num > 0 && all_equal)
            {
                if (num % 10 != prev_dig)
                {
                    all_equal = false;
                    Console.WriteLine("DIFFERENT");
                }

                prev_dig = num % 10;
                num /= 10;
            }

            if (all_equal)
            {
                Console.WriteLine("ALL EQUAL");
            }
        }
    }
}
