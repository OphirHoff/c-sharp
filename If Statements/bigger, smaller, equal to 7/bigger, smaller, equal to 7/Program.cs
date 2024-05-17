using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigger__smaller__equal_to_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number: ");
            // Get an integer from the user
            int num = int.Parse(Console.ReadLine());

            // check if the integer is bigger, smaller or equal 7
            if (num > 7)
                Console.WriteLine("a lot");

            else if (num < 7)
                Console.WriteLine("a little");

            else
                Console.WriteLine("Bingo");
        }
    }
}
