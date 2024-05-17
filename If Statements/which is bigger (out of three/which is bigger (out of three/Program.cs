using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace which_is_bigger__out_of_three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            // get first number from user
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            // get second number
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            // get third number
            int num3 = int.Parse(Console.ReadLine());

            // check if first number > second number
            if (num1 > num2)
            {
                // check if first number > third number
                if (num1 > num3)
                    Console.WriteLine(num1);

                // check if first number < third number
                else if (num1 < num3)
                    Console.WriteLine(num3);
            }
            // check if first number > second number
            else if (num1 < num2)
            {
                // check if second number > third number
                if (num2 > num3)
                    Console.WriteLine(num2);
                // check if second number < third number
                else if (num2 < num3)
                    Console.WriteLine(num3);
            }
            

        }
    }
}
