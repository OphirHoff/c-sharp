using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_numbers_divisible_by_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Go through all numbers from -9 to 60
            for (int i = -9; i <= 60; i++)
            {
                // Check every number if is divisible by 5
                if (i % 5 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
