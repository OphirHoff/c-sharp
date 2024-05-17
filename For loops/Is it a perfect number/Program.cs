using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_it_a_perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 1;
            string equation = "1";

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    equation += "+" + i;
                }
            }


            if (sum == num)
            {
                Console.WriteLine(num + " is a perfect number: " + equation  + "=" + num);
            }

            else
            {
                Console.WriteLine("This is not a perfect number");
            }
        }
    }
}
