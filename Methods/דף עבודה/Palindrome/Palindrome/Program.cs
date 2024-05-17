using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        public static bool Palindrome (int num)
        {   
            //save the num as string (gibui)
            string saveNum = ""; 
            saveNum += num;

            string RevNum = ""; //reversed number variable
            // reverse the number
            while (num > 0)
            {
                RevNum += (num % 10); //the units and add to reversed number
                num /= 10; // get rid of the units
            }

            // check if reversed number is the same as the original number
            if (saveNum == RevNum) 
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Palindrome(num));
        }
    }
}
