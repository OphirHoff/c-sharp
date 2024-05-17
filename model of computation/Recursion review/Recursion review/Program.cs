using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_review
{
    internal class Program
    {
        public static string ConvertBase(int num, int b)
        {
            if (num == 0)
                return string.Empty;

            return ConvertBase(num / b, b).ToString() + (num % b).ToString();
        }

        public static int MinDigit(int num)
        {
            if (num < 10)
                return num;

            return Math.Min(num % 10, MinDigit(num / 10));
        }

        public static bool Check(int[] arr, int last_index, int m)
        {
            if (last_index == 0)
                return MinDigit(arr[last_index]) == m;

            return MinDigit(arr[last_index]) == m && Check(arr, last_index-1, m);
        }

        public static bool IsValueIn(int[] a, int x, int m)
        {
            if (m == 0)
                return true;

            if (a)
        }

        static void Main(string[] args)
        {
            int[] a = { 3389, 5324, 52, 324 };

            Console.WriteLine(Check(a, a.Length-1, 2));
        }
    }
}
