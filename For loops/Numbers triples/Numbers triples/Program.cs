using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_triples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                //Get first num from user
                Console.WriteLine("Enter first number");
                int num1 = int.Parse(Console.ReadLine());

                // second num from user
                Console.WriteLine("Enter second number");
                int num2 = int.Parse(Console.ReadLine());

                // third num from user
                Console.WriteLine("Enter third number");
                int num3 = int.Parse(Console.ReadLine());

                // claculate avarage
                double avarage = (num1 + num2 + num3) / 3;
                Console.WriteLine("Avarage: " + avarage);
                // Check if second number equals to avarage
                if (num2 == avarage)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");

            }



        }
    }
}
