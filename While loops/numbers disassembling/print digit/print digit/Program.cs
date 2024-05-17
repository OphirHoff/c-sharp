using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter digit number");
            int digit = int.Parse(Console.ReadLine());

            for (int i = 1; i < digit; i++)
            {
                num /= 10;
            }

            if (num > 0)
            {
                Console.WriteLine(num % 10);
            }
            else
            {
                Console.WriteLine("-1");
            }

        }
    }
}
