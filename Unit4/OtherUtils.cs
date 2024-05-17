using System;
using System.Text;

namespace Unit4
{
    public static class OtherUtils
    {
        public static void Test_OtherUtils()
        {
            int[] a = { 1, 4, 7, 9 };
            int[] b = { 1, 3, 7, 9 };
            Console.WriteLine(ArrayCompare(a, b));
        }
        public static bool ArrayCompare(int[] a1, int[] a2)
        {
            if (a1.Length != a2.Length)
                return false;
            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] != a2[i])
                    return false;
            }
            return true;
        }
        public static void ArrayPrint<T>(T[] a)
        {
            Console.Write($"[");
            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.Write($"{a[i]}, ");
            }
            Console.WriteLine($"{a[a.Length - 1]}]");
        }
    }
}
