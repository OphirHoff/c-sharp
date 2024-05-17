using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        public static int Factorial(int n)
        {
            for (int i = n - 1; i > 1; i--)
            {
                n *= i;
            }
            return n;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (int.TryParse(args[i]))
                Console.WriteLine(Factorial(int.Parse(s)));
            }
        }
    }
}
