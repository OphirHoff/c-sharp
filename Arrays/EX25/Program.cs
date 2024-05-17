using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX25
{
    class Program
    {
        public static int[] Merge(int [] arr1, int [] arr2)
        {
            int i1 = 0, i2 = 0, i3 = 0;
            int[] arr3 = new int[arr1.Length + arr2.Length];
            bool done1 = false, done2 = false;

            while (!done1 && !done2)
            {
                if (arr1[i1] < arr2[i2])
                {
                    arr3[i3] = arr1[i1];
                    if (i1 == arr1.Length - 2)
                    {
                        done1 = true;
                    }
                    i1++;

                    if (i3 < arr3.Length - 2)
                    {
                        i3++;
                    }
                }

                else if (arr1[i1] > arr2[i2])
                {
                    arr3[i3] = arr2[i2];
                    if (i2 == arr2.Length - 2)
                    {
                        done2 = true;
                    }
                    i2++;
                    if (i3 == arr3.Length - 2)
                    {
                        i3++;
                    }

                }

                else
                {
                    arr3[i3] = arr2[i2];
                    if (i1 == arr1.Length - 2)
                    {
                        done1 = true;
                        i1++;
                    }
                    if (i2 == arr2.Length - 2)
                    {
                        done2 = true;
                        i2++;
                    }
                    if (i3 == arr3.Length - 2)
                    {
                        i3++;
                    }

                }
            }
            return arr3;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 30, 70, 72, 74, 77, 80 };
            int[] arr2 = { 1, 2, 5, 10, 20, 73 };

            int[] arr3 = Merge(arr1, arr2);

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + ", ");
            }
        }
    }
}
