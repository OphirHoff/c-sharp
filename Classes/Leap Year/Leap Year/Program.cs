using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Year
{
    internal class Program
    {
        public static int HowManyDays(int year)
        {
            int leapYear = year % 19;
            if (leapYear == 3 || leapYear == 6 || leapYear == 8 || leapYear == 11 || leapYear == 14 || leapYear == 17 || leapYear == 0)
                return 29;
            else
                return 28;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(HowManyDays(2020));
        }
    }
}
