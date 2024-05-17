using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArraysEx1
{
    internal class Program
    {
        public static void Ex1()
        {
            Random random = new Random();
            int[] arr = new int[10];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1,11);
            }

            for (int i = 0; i<10; i++)
            {
                Console.Write(arr[i] + ",");
            }

            int [] arr2 = new int[arr.Length];
            for (int i = arr.Length-1; i >=0 ; i--)
            {
                arr2[arr.Length -1 - i] = arr[i];
            }
            Console.WriteLine();
            for (int i = 0; i <10; i++)
            {
                Console.Write(arr2[i] + ",");
            }
        }

        public static void Ex2()
        {
            Random rnd = new Random();
            int[] arr = new int[5];
            for(int i =0; i<arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 11);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + ",");
            }

            int num = 2;
            Console.WriteLine();
            Console.WriteLine(num);
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > num)
                    count++;
            }

            Console.WriteLine(count);
        }

        public static void Ex3()
        {
            Random rnd = new Random();
            int[] arr = new int[8];
            int last = int.MinValue, count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 11);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < last)
                    count++;

                last = arr[i];
            }

            Console.WriteLine();
            Console.WriteLine(count);
        }

        public static void Ex4()
        {
            Random rnd = new Random();
            int[] arr = new int[7];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 11);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }

            int even = 0, odd = 0, oddSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    even++;
                else
                {
                    odd++;
                    oddSum += arr[i];
                }
            }

            Console.WriteLine("even: " + even);
            Console.WriteLine("odd: " + odd);
            if(odd > 0)
            {
                double avg = (double)oddSum / odd;
                Console.WriteLine("avg: " + avg);
            }
        }

        public static void Ex5()
        {
            Random rnd = new Random();
            int[] arr = new int[7];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 11);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }

            bool ole = true;
            
            for(int i = 1; i < arr.Length && ole; i++)
            {
                ole = arr[i] >= arr[i - 1];
            }

            Console.WriteLine(ole);
        }

        public static void Ex6()
        {
            Random rnd = new Random();
            int[] arr = new int[10];

            int posCount = 0, negCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 11);
                if (arr[i] > 0)
                    posCount++;
                else
                    negCount++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }

            int[] pos = new int[posCount];
            int[] neg = new int[negCount];
            int posi = 0, negi = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    pos[posi] = arr[i];
                    posi++;
                }
                else
                {
                    neg[negi] = arr[i];
                    negi++;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < pos.Length; i++)
            {
                Console.Write(pos[i] + ",");
            }
            Console.WriteLine();
            for (int i = 0; i < neg.Length; i++)
            {
                Console.Write(neg[i] + ",");
            }
        }

        public static void Ex7(int[] arr)
        {
            bool cont = true;
            int last = arr[0];

            for (int i = 1; i < arr.Length && cont; i++)
            {
                if (arr[i] != last)
                {
                    cont = false;
                }
                last = arr[i];
            }

            Console.WriteLine(cont);
        }

        //Ex8
        public static int MaxIndex(int[] arr)
        {
            int max = arr[0] - 1;
            int maxi = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxi = i;
                }
            }
            return maxi;
        }

        public static int Counter(int[] arr, int index)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr[index])
                {
                    count++;
                }
            }
            return count;
        }

        public static void Ex8()
        {
            Random rnd = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(4,28);
            }

            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }

            int[] cnt = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                cnt[i] = Counter(arr, i);
            }

            Console.WriteLine(arr[MaxIndex(cnt)]);
        }

        //Ex9
        public static bool Match(int[] A, int Index, int[] B)
        {
            bool foundMatch = false;
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == A[Index])
                {
                    foundMatch = true;
                }
            }
            return foundMatch;
        }

        public static void Ex9()
        {
            int[] A = new int[5];
            for(int i = 0; i<A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + ",");
            }

            Console.WriteLine();

            int[] B = new int[5];
            for (int i = 0; i<B.Length; i++)
            {
                B[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i] + ",");
            }

            int matchCount = 0;
            for(int i = 0; i < A.Length; i++)
            {
                if (Match(A, i, B) == true)
                    matchCount++;
            }

            int[] C = new int[matchCount];
            int cIndex = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (Match(A, i, B) == true)
                {
                    C[cIndex] = A[i];
                    cIndex++;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < C.Length; i++)
            {
                Console.Write(C[i] + ",");
            }
        }

        public static void Ex10()
        {
            int[] arr = new int[4];
            int sum = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }

            double avg = (double)sum / arr.Length;
            double deviationSum = 0;

            for (int i=0; i<arr.Length; i++)
            {
                double deviation = Math.Pow((arr[i] - avg), 2);
                deviationSum += deviation;
                Console.WriteLine(arr[i]+": " + deviation);
            }

            double standartDeviation  = (double)Math.Sqrt((double)deviationSum/arr.Length);
            Console.WriteLine(standartDeviation);
        }
        static void Main(string[] args)
        {
            Ex10();
        }
    }
}
