using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_of_digits
{
    class Program
    {
        public static int DigitNum (int num)
        {
            int count = 0; // Counter - number of digits

            while (num > 0) // Disassembly the number
            {
                count++;
                num /= 10;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(DigitNum(num));
        }
    }
}
