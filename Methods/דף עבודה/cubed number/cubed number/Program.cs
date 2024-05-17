using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubed_number
{
    internal class Program
    {
        public static double Power3 (double num)
        {
            return Math.Pow(num, 3);
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Power3(num));
        }
    }
}
