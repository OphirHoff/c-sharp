using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numers_disassembly_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine()); // number input

            int sum = 0; // sum of digits counter

            while (num != 0) // keep going 'till num is 0
            {
                sum += num % 10; // add units to sum
                num /= 10; // get rid of units
            }

            Console.WriteLine("sum=" + sum);
        }
    }
}
