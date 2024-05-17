using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversed_number
{
    internal class Program
    {
        public static int Digits(long num)
        {
            int count = 0;
            while(num!=0)
            {
                num /= 10;
                count++;
            }
            return count;
        }

        public static bool SpinNum(long num)
        {
            int powerOfTen = Digits(num)-1;

            long saveNum = num;
            long newNum = 0;
            while(num > 0)
            {
                long units = num % 10;

                if (units == 6)
                    newNum += (long)Math.Pow(10, powerOfTen) * 9;
                else if (units == 9)
                    newNum += (long)Math.Pow(10, powerOfTen) * 6;
                else
                    newNum += (long)Math.Pow(10, powerOfTen) * units;

                powerOfTen--;
                num /= 10;
            }

            if (newNum == saveNum)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            long x = 100006900001;
            Console.WriteLine(x + " " + SpinNum(x));
            x = 916;
            Console.WriteLine(x + " " + SpinNum(x));
            x = 96;
            Console.WriteLine(x + " " + SpinNum(x));
            x = 180619081;
            Console.WriteLine(x + " " + SpinNum(x));
            x = 61801010819;
            Console.WriteLine(x + " " + SpinNum(x));
            x = 304815;
            Console.WriteLine(x + " " + SpinNum(x));
            x = 110;
            Console.WriteLine(x + " " + SpinNum(x));

            Console.WriteLine("Press key !");
            Console.ReadKey();

        }
    }
}
