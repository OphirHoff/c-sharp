using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_numbers_not_included
{
    internal class Program
    {
        public static int DigCount (int num)
        {
            int count = 0;
            while (num != 0)
            {
                count++;
                num /= 10;
            }
            return count;
        }

        public static int DifDig (int num)
        {
            int count = DigCount(num);

            for(int i = 1; i <= DigCount(num); i++)
            {
                int units = num % 10;
                int saveNum = num / 10;

                while (saveNum != 0)
                {
                    if (units == saveNum % 10)
                    {
                        count--;
                    }
                    saveNum /= 10;
                }
                num /= 10;
            }
            return count;
        }

        public static int FinalNum (int num)
        {
            int digNum = 10 - DifDig(num);
            int newNum = 0;

            for (int i = 0; i < 10; i++)
            {
                int saveNum = num;
                bool found = false;

                while(saveNum != 0 && found == false)
                {
                    int units = saveNum % 10;
                    if (units == i)
                    {
                        found = true;
                    }
                    saveNum /= 10;
                }

                if (found == false)
                {
                    newNum += i * (int)Math.Pow(10, digNum - 1);
                    digNum--;
                }
            }
            return newNum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(FinalNum(num));
        }
    }
}
