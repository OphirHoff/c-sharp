using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pali2
{
    internal class Program
    {
        public static int DigCount (int num)
        {
            int count = 0;
            while (num > 0)
            {
                count++;
                num /= 10;
            }
            return count;
        }

        public static bool Palindrome (int num)
        {
            int newNum = 0;
            int saveNum = num;
            int powerOfTen = DigCount(num) - 1;

            while (num > 0)
            {
                newNum += (num % 10) * (int)Math.Pow(10, powerOfTen);
                powerOfTen--;
                num /= 10;
            }

            if (saveNum == newNum)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Palindrome(num));
        }
    }
}
