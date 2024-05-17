using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number
{
    internal class Program
    {
        public static bool Prime (int num)
        {
            bool is_prime = true;
            for (int i = 2; i < num; i++) // repeat on every number from 2 to num-1
            {
                if (num % i == 0)// check if divisible
                {
                    is_prime = false;
                }
            }

            if (is_prime) // final check if prime before returning
                return true;

            return false;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Prime(num));
        }
    }
}
