using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, add, sub, mul, div;

            a = 4;
            b = 5;
            add = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;

            Console.WriteLine("Addition => " + add);
            Console.WriteLine("Subtraction => " + sub);
            Console.WriteLine("Multiplicataion => " + mul);
            Console.WriteLine("Division => " + div);
        }
    }
}
