using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positive_or_negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            // get a number from user
            int num = int.Parse(Console.ReadLine());

            // check if the number is bigger or smaller than 0
            if (num > 0)
                Console.WriteLine("Positive");
            else if (num < 0)
                Console.WriteLine("Negative");
        }
    }
}
