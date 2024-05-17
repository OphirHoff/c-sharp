using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool stop = false;

            for (int i = 1; stop == false; i++)
            {
                Console.WriteLine("Enter number # " + i);
                int num = int.Parse(Console.ReadLine());


                if(num % 2 == 0 && num % 4 != 0)
                {
                    sum += num;
                }
                if (num < 0)
                {
                    stop = true;
                }
            }

            Console.WriteLine("sum=" + sum);


        }
    }
}
