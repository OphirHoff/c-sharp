using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sum
{
    class Program
    {

        public static int ArrSum (int [] arr , int i)
        {
            if (i == arr.Length - 1)
                return arr[i];

            return arr[i] + ArrSum(arr, i + 1);
        }

        public static int Pos(int [] arr, int i)
        {
            if (i == arr.Length-1)
            {
                if (arr[i] > 0)
                    return 1;
                return 0;
            }

            if (arr[i] > 0)
                return 1 + Pos(arr, i + 1);
            return Pos(arr, i + 1);
        }

        public static int NumCnt(int [] arr, int i, int n)
        {
            if (i == arr.Length - 1)
            {
                if (arr[i] == n)
                    return 1;
                return 0;
            }

            if (arr[i] == n)
                return 1 +NumCnt(arr, i + 1, n);
            return NumCnt(arr, i + 1, n);
        }
        static void Main(string[] args)
        {
            int[] arr = { -1, 3, -5, 3, 9 };

            Console.WriteLine(NumCnt(arr, 0, 3));


            
        }

    }
}
