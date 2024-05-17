using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace is_it_a_letter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a chatacter: ");
            // get a character from user
            char character = char.Parse(Console.ReadLine());

            // convert the character into an ascii number
            int ascii_num = (int) character;

            // check if the ascii number represents a letter
            if ((ascii_num >= 65 && ascii_num <= 90) || (ascii_num >= 97 && ascii_num <= 122))
                Console.WriteLine("This is a letter");
            else
                Console.WriteLine("This is not a letter");

        }
    }
}
