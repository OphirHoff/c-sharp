using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx3
{
    internal class Program
    {
        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "|");
            }
        }

        public static void Ex1()
        {
            int[] arr = new int[101];

            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 101);
            }

            PrintArr(arr);
        }

        public static void Ex2()
        {
            Random rnd = new Random();

            int[] arr = new int[15];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 6);
            }
            PrintArr(arr);

            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    int save = arr[i];
                    arr[i] = arr[index];
                    arr[index] = save;
                    index++;
                }
            }

            Console.WriteLine();
            PrintArr(arr);
        }

        public static void Ex3()
        {
            Random rnd = new Random();

            int[] arr = { 13, 15, 17, 10, 11, 29, 33, 34, 45, 32, 32, 33, 40, 40, 49 };
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(10, 51);
            }
            PrintArr(arr);

            int length = -1;
            int newLength = 1;
            int indexStart = 0;
            int newIndexStart = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < arr[i+1])
                {
                    newIndexStart = i;
                    while (arr[i] < arr[i+1] && i < arr.Length-1)
                    {
                        newLength++;
                        i++;
                    }
                    i = newIndexStart;
                }

                if (newLength > length)
                {
                    length = newLength;
                    indexStart = newIndexStart;
                }
            }

            
            for (int i = indexStart; i < length; i++)
            {
                Console.WriteLine(arr[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Begins: " + indexStart);
            Console.WriteLine("Length: " + length);
        }

        public static int DigCount(int num)
        {
            int cnt = 0;
            while (num != 0)
            {
                cnt++;
                num /= 10;
            }
            return cnt;
        }
        public static void Ex4(int num)
        {
            int[] arr = new int[10];
            while(num != 0)
            {
                int dig = num % 10;
                arr[dig]++;
                num /= 10;
            }


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine(i + ": " + arr[i] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            Ex4(18515);
        }
    }
}
