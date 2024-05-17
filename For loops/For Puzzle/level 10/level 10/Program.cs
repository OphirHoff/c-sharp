using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number for start");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number for end");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("***");

            for (int i = num1; i < num2; i++)
            {
                if (i % 10 == 1)
                {
                    Console.Write(i + "st, ");
                }

                else if (i % 10 == 2)
                {
                    Console.Write(i + "nd, ");
                }

                else if (i % 10 == 3)
                {
                    Console.Write(i + "rd, ");
                }

                else
                {
                    Console.Write(i + "th, ");
                }
            }


        }
    }
}
