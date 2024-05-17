using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirror_number
{
    internal class Program
    {
        public static void MirrorNum (int num)
        {
            Console.Write(num);

            while (num != 0)
            {
                Console.Write(num % 10);
                num /= 10;
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            MirrorNum(num);
        }
    }
}
