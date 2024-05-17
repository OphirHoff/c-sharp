using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Square
{
    class Program
    {
        public static int Mod(int x, int m)
        {
            return (x % m + m) % m;
        }

        public static void SolveMagicSqr(int[,] arr)
        {

            int row = 0;
            int clmn = arr.GetLength(0) / 2;
            
            arr[row, clmn] = 1;

            int cnt = 2;

            for (int i = 0; i < Math.Pow(arr.GetLength(1), 2)-1; i++)
            {
                

                if (arr[Mod(row - 1, arr.GetLength(0)), Mod(clmn + 1, arr.GetLength(0))] == 0)
                {
                    row = Mod(row - 1, arr.GetLength(0));
                    clmn = Mod(clmn + 1, arr.GetLength(0));
                    arr[row, clmn] = cnt;
                }

                else
                {
                    row = Mod(row + 1, arr.GetLength(0));
                    arr[row, clmn] = cnt;
                }

                cnt++;
            }
        }

        static void Main(string[] args)
        {

            int[,] arr = new int[7, 7];

            SolveMagicSqr(arr);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]/10 +""+ arr[i,j]%10 + ", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[,] arr2 = new int[11, 11];

            SolveMagicSqr(arr2);

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j]/100 + "" + ((arr2[i, j]/10) - (arr2[i, j] / 100*10) + "" + arr2[i, j]%10 + ", "));
                }
                Console.WriteLine();
            }
        }
    }
}
