using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
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

            Console.WriteLine("Enter Operation(+, -, *, :, ^): ");
            // get mathematical operation from user
            char operation = char.Parse(Console.ReadLine());

            // check operation input from user and calculate according to it
            if (operation == '+' )
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            else if (operation == '-')
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            else if (operation == '*')
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            else if (operation == ':')
            // Define error of division by zero
            {
                if (num2 == 0)
                    Console.WriteLine("Error: division by zero is undefined");
                else
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }
            else if (operation == '^')
                Console.WriteLine($"{num1} ^ {num2} = {Math.Pow(num1, num2)}");

        }
    }
}
