using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String : ");
            string str = Console.ReadLine();

            // Enter the char which you want to
            // search for its position.
            Console.WriteLine("Enter the character:");
            ConsoleKeyInfo ch = Console.ReadKey();

            

            int indexPosition = -1;

            // Count the index position of char in string.

            int x = 3;
            int y = 2;


            


            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch.KeyChar)
                {
                    indexPosition = i;
                    break;
                }
            }

            if (indexPosition == -1)
            {
                Console.WriteLine("character, {0} is not found in string", ch.KeyChar);
            }
            else
            {
                Console.WriteLine("character, {0} is  found in string at {1} position", ch.KeyChar, indexPosition + 1);
            }
        }
    }
}
