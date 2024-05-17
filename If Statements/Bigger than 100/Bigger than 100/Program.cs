using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigger_than_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number: ");
            // Get an integer from the user
            int num = int.Parse(Console.ReadLine());

            // check if the number is bigger than 100
            if (num > 100)
            {
                Console.WriteLine("Bigger");
            }

        }
    }
}
