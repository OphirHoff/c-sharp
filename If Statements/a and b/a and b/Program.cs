using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_and_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            // get first number from user
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            // get second number from user
            int b = int.Parse(Console.ReadLine());

            // check if numbers meet all the conditions
            if (a > b && (a % 2 == 0 || b % 2 == 0))
            {
                if ((a - b) % 2 == 0)
                    Console.WriteLine("BOTH EVEN");

                else
                    Console.WriteLine(a + b);
            }
        }
    }
}
