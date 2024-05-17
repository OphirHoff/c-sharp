using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Simetric_Sum_array
{
    internal class Program
    {
        public static bool SimetricSum(int[] arr, int i)
        {
            if (i == arr.Length/2)
                return true;

            return arr[i] + arr[arr.Length-1-i] == arr[i + 1] + arr[arr.Length-2-i] && SimetricSum(arr, i+1);
        }
        public static bool SimetricSum(int[] arr)
        {
            return SimetricSum(arr, 0);
        }

        public static int[] Multiply(int[] arr1, int[] arr2)
        {
            int[] newArr = new int[Math.Max(arr1.Length, arr2.Length)];

            int index = 0;

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                newArr[i] = arr1[i] * arr2[i];
                index = i;
            }

            index++;

            while (index < Math.Max(arr1.Length, arr2.Length))
            {
                if (index >= arr2.Length)
                    newArr[index] = arr1[index];

                else
                    newArr[index] = arr2[index];

                index++;
            }

            return newArr;
        }

        public static bool IsPerfect(int[] arr)
        {
            int index = 0;
            int cnt = 0;

            bool foundZero = false;


            for (int i = 0; i < arr.Length && !foundZero; i++)
            {
                if (arr[index] == 0)
                    foundZero = true;

                index = arr[index];
                cnt++;
            }

            return cnt == arr.Length && foundZero;
        }
        static void WhatPrint(string a, int m)
        {
            string a0, a1;
            if (m == 0)
                Console.WriteLine(a);
            else
            {
                a0 = a;
                a1 = a;
                a0 = a0 + "0";
                a1 = a1 + "1";
                WhatPrint(a0, m - 1);
                WhatPrint(a1, m - 1);
            }
        }

        static void Main(string[] args)
        {
            WhatPrint("", 4);
        }
    }
}
