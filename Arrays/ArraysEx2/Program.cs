using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] arr = new char[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }

            bool found = false;

            for (int i = 0; i < arr.Length; i++)
            {
                char letter = arr[i];
                for (int index = 0; i < arr.Length; i++)
                {
                    if ((char)arr[index] == letter)
                    {
                        found = true;
                        Console.WriteLine(letter + "found");
                    }
                    
                }
            }
        }
    }
}
