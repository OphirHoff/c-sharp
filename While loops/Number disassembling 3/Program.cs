using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_disassembling_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSum = 0;

            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            int numMaxSum = num;

            while (num >= 0)
            {
                int digitsSum = 0;
                int saveNum = num; // גיבוי

                while (num > 0) //פירוק מספר
                 {
                    digitsSum += num % 10;
                    num /= 10;
                 }

                if (digitsSum > maxSum)
                {
                    maxSum = digitsSum;
                    numMaxSum = saveNum;
                }

                Console.WriteLine("Enter a number:");
                num = int.Parse(Console.ReadLine());
             }
            if (maxSum > 0)
            {
                Console.WriteLine(numMaxSum);
            }
        }
    }
}
