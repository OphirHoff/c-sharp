using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx22._1._23
{
    class Program
    {
        public static int[] Ex(int num)
        {
            int[] numbers = new int[num];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = i + 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "|");
            }

            int[] arr = new int[num];
            Random rnd = new Random();
            for (int i = 0; i < num ; i++)
            {
                int index = rnd.Next(0, num);
                arr[i] = numbers[index];
                numbers[index] = numbers[num - 1];
            }

            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = Ex(10);
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "|");
            }
        }
    }
}
