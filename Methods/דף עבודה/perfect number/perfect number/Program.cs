using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    internal class Program
    {
        public static bool Perfect (int num)
        {
            int sum = 0; // sum od dividers
            for (int i = 1; i < num; i++) //go over all numbers from 1 to num-1
            {
                if (num % i == 0)// check if is divisible
                {
                    sum += i; // add to sum of dividers
                }
            }
            if (sum == num) // check if sum of dividers equals to number
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Perfect(num));
        }
    }
}
