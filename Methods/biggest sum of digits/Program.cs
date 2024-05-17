using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biggest_sum_of_digits
{
    class Program
    {
        public static int sumDigits (int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            int sumNum1 = sumDigits(num1);
            int sumNum2 = sumDigits(num2);

            if (sumNum1 > sumNum2)
            {
                Console.WriteLine(num1);
            }
            else if (sumNum2 > sumNum1)
            {
                Console.WriteLine(num2);
            }
        }
    }
}
