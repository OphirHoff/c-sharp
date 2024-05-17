using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators_without_math_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            // gets first number from user
            float num1 = float.Parse(Console.ReadLine());

            //gets second number from user
            Console.WriteLine("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            // MAX
            // Finds the biggest number between the two
            if (num1 > num2)
                Console.WriteLine("Max = " + num1);

            else if (num2 > num1)
                Console.WriteLine("Max = " + num2);

            // MIN
            // Finds the smallest number between the two
            if (num1 < num2)
                Console.WriteLine("Min = " + num1);

            else if (num2 < num1)
                Console.WriteLine("Min = " + num2);

            // ABS
            // Finds the absolute value of each number
            if (num1 < 0) // -> find out if the number if negative, if it is - turn it positive
            {
                Console.WriteLine("ABS = " + num1/-1);

            }
            else
                Console.WriteLine("ABS = " + num1);


            if (num2 < 0) // -> find out if the number if negative, if it is - turn it positive
            {
                Console.WriteLine("ABS = " + num2/-1);
            }
            else
                Console.WriteLine("ABS = " + num2);

            // ROUND
            // Rounds each one of the numbers according to it's fraction
            // whole first number
            int whole_num1 = (int)num1;
            // fraction of first number
            float num1_fractions = num1 - whole_num1;

            // check fraction value
            if (num1_fractions <= 0.49)
                Console.WriteLine("Round: " + whole_num1);
            else if (num1_fractions >= 0.50)
                Console.WriteLine("Round: " + (whole_num1 + 1));

            // whole second number
            int whole_num2 = (int)num2;
            // fraction of second number
            double num2_fractions = num2 - whole_num2;

            // check fraction value
            if (num2_fractions <= 0.49)
                Console.WriteLine("Round: " + whole_num2);
            else if (num2_fractions >= 0.50)
                Console.WriteLine("Round: " + (whole_num2 + 1));

            // FLOOR
            // Prints the whole number
            Console.WriteLine("Floor: " + (num1 - num1_fractions));
            Console.WriteLine("Floor: " + (num2 - num2_fractions));

        }   }
}
