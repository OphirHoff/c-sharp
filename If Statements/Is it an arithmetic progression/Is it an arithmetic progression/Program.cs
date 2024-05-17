using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Is_it_an_arithmetic_progression
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number: ");
            // get first number from user
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            // get second number from user
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            // get third number from user
            int num3 = int.Parse(Console.ReadLine());

            //Organize numbers from biggest to smallest
            int max = 0;
            int mid = 0;
            int min = 0;

            if (num1 >= num2 && num1 >= num3)
            {
                max = num1;
                if (num2 >= num3)
                {
                    mid = num2;
                    min = num3;
                }
                else
                {
                    mid = num3;
                    min = num2;
                }
            }
            //------
            if (num2 >= num1 && num2 >= num3)
            {
                max = num2;
                if (num1 >= num3)
                {
                    mid = num1;
                    min = num3;
                }
                else
                {
                    mid = num3;
                    min = num1;
                }
            }
            //----------
            if (num3 >= num1 && num3 >= num2)
            {
                max = num3;
                if (num1 >= num2)
                {
                    mid = num1;     
                    min = num2;
                }
                else
                {
                    mid = num2;
                    min = num1;
                }
            }

            Console.WriteLine(max + " " + mid + " " + min);

            if (max - mid == mid - min)
                Console.WriteLine("This is an arithmetic progression");
            else
                Console.WriteLine("This is NOT an arithmetic progression");

        }
        }
}
