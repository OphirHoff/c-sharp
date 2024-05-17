using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dividers
{
    internal class Program
    {
        public static void Dividers (int num)
        {
            for (int i = 1; i < num; i++) // Repeat from 1 to number-1
            {
                if (num % i == 0) // check if number divides by it
                {
                    Console.WriteLine(i); // print the divider
                }
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dividers(num);
        }
    }
}
