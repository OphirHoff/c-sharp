using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        public static int factorial (int num)
        {
            for (int i = num-1; i >0; i--)
            {
                num *= i;
            }
            return num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(factorial(num));
        }
    }
}
