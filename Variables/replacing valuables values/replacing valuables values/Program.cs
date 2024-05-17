using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replacing_valuables_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Second number: ");
            int num2 = int.Parse(Console.ReadLine());

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;


            Console.WriteLine(num1 + " " + num2);


        }
    }
}
