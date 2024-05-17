using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_disassembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of digits");
            int digits = int.Parse(Console.ReadLine()); // מספר הספרות

            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine()); // המספר עצמו

            int sum = 0;  // צובר סכום הספרות

            for (int i = 1; i <= digits; i++) // חוזר כמספר הספרות
            {
                sum += num % 10; // אחדות
                num /= 10; // קוצץ את האחדות
            }

            Console.WriteLine("sum=" + sum);
        }
    }
}
