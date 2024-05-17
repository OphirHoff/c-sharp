using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RecursionExcercises
{
    internal class Program
    {

        public static int DigCount(int num)
        {
            if (num < 10)
                return 1;

            return DigCount(num / 10) + 1;
        }

        public static int DigSum(int num)
        {
            if (num < 10)
                return num;

            return DigSum(num / 10) + num % 10;
        }

        public static int Power(int baseNum, int power)
        {
            if (power == 0)
                return 1;

            return Power(baseNum, power - 1) * baseNum;
        }

        public static int Factorial(int num)
        {
            if (num == 1)
                return 1;

            return Factorial(num - 1) * num;
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static int GetSum(int num1, int num2)
        {
            if (num2 == 0)
                return num1;

            return GetSum(num1 + 1, num2 - 1);
        }

        public static int GetMul(int num1, int num2)
        {
            if (num2 == 1)
                return num1;

            return num1 + GetMul(num1, num2 - 1);
        }

        public static int FindInSeries(int n, int first, int difference)
        {
            if (n == 1)
                return first;

            return difference + FindInSeries(n - 1, first, difference);
        }

        public static int SeriesSum(int n, int first, int difference)
        {
            if (n == 1)
                return first;

            return FindInSeries(n, first, difference) + SeriesSum(n - 1, first, difference);
        }

        public static void Hourglass(int n)
        {
            if (n == 1)
            {
                Console.WriteLine("1");
                return;
            }

            Console.WriteLine(new String((char)(n + 48), n));
            Hourglass(n - 1);
            Console.WriteLine(new String((char)(n + 48), n));
        }

        public static bool SederOle(int num)
        {
            if (num == 0)
                return true;


            return SederOle(num / 10) && num % 10 > (num / 10) % 10;
        }

        public static bool IsDigInNum(int num, int digit)
        {
            if (num < 10)
                return num == digit;

            return (digit == num % 10) || IsDigInNum(num / 10, digit);
        }

        public static int MouseAndChoclate(int[,] arr)
        {
            // Base Case (stop condition) - a 1x1 array
            if (arr.GetLength(0) == 1)
                return arr[0, 0];

            // Make an array of N-1 x N-1 of the square around the point with more choclate
            int [,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(0)-1];

            // more choclate down
            if (arr[1, 0] > arr[1, 1])
            {
                for (int i = 0; i < newArr.GetLength(0); i++)
                {
                    for (int j = 0; j < newArr.GetLength(0); j++)
                    {
                        newArr[i, j] = arr[i+1, j];
                    }
                }
            }

            // more choclate on down right diagonal
            else
            {
                for (int i = 0; i < newArr.GetLength(0); i++)
                {
                    for (int j = 0; j < newArr.GetLength(0); j++)
                    {
                        newArr[i, j] = arr[i + 1, j + 1];
                    }
                }
            }
            
            return arr[0, 0] + MouseAndChoclate(newArr);
        }

        private static int MaxValue(int[] n, int i)
        {
            if (i == 0)
                return n[0];

            if (MaxValue(n, i - 1) > n[i])
                return MaxValue(n, i - 1);

            return n[i];
        }
        // פעולה עוטפת
        public static int MaxValue(int[] n)
        {
            return MaxValue(n, n.Length - 1);
        }

        public static void Reverse (int n)
        {
            if (n < 10)
            {
                Console.Write(n);
                return;
            }

            Console.Write(n%10);
            Reverse(n/10);
        }

        public static bool IsDigIn(int num, int dig)
        {
            if (num < 10)
                return num == dig;

            return (num%10 == dig) || IsDigIn(num/10, dig);
        }

        public static void ReverseString(string str)
        {
            if (str.Length == 1)
            {
                Console.Write(str);
                return;
            }

            Console.Write(str.Substring(str.Length-1));
            ReverseString(str.Substring(0, str.Length - 1));
        }

        public static bool AllDigEven(int n)
        {
            if (n < 10)
                return n % 2 == 0;

            return ((n%10)%2==0) && AllDigEven(n/10);
        }

        public static double DigAvg(int n)
        {
            return DigSum(n) / DigCount(n);
        }

        public static bool ArithmeticProgression(int[] arr, int end)
        {
            if (end == 1)
                return true;

            return (arr[end] - arr[end - 1]) == (arr[end - 1] - arr[end - 2]) && ArithmeticProgression(arr, end-1);
        }
        public static bool ArithmeticProgression(int[] arr)
        {
            return ArithmeticProgression(arr, arr.Length - 1);
        }

        public static bool GoingUp(int[] arr, int end)
        {
            if (end == 0)
                return true;

            return arr[end] >= arr[end - 1] && GoingUp(arr, end - 1);
        }
        public static bool GoingUp(int[] arr)
        {
            return GoingUp(arr, arr.Length - 1);
        }

        public static int ArrSum(int[] arr, int end)
        {
            if (end == 0)
                return arr[end];

            return arr[end] + ArrSum(arr, end - 1);
        }
        public static int ArrSum(int[] arr)
        {
            return ArrSum(arr, arr.Length - 1);
        }

        static void Main(string[] args)
        {

            int[] arr = { 8 };
            Console.WriteLine(ArrSum(arr));

        }
    }
}
