using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        public static int Factorial (int num)
        {
            int kefel = num; // multiplication of all numbers

            // go over all numbers from num-1 down to 2
            for (int i = num - 1; i > 1; i--)
            {
                kefel *= i; // multiply by i
            }
            return kefel;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(num));
        }
    }
}
