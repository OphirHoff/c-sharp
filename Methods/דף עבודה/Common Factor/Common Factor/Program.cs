using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Common_Factor
{
    internal class Program
    {
        public static int CommonFactor (int num1, int num2)
        {
            int MaxCommonFactor = 0; // biggest common factor

            bool found = false; // condition for keep looking for a factor

            // go over all numbers from the smallest of them down to 1
            for (int i = Math.Max(num1, num2); i > 0 && found == false; i--)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    MaxCommonFactor = i;
                    found = true;
                }
            }
            return MaxCommonFactor;
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(CommonFactor(num1, num2));

        }
    }
}
