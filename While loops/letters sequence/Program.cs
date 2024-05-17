using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letters_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSequenceLenght = 0; ;

            Console.WriteLine("Enter a character:");
            char letter = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter a character:");
            char newLetter = char.Parse(Console.ReadLine());

            while (newLetter != '%')
            {
                int sequenceLength = 1;
                if (newLetter == letter)
                {
                    sequenceLength++;
                }

                else
                {
                    sequenceLength = 1;
                }

                if (sequenceLength > maxSequenceLenght)
                {
                    maxSequenceLenght = sequenceLength;
                }

                letter = newLetter;
                newLetter = char.Parse(Console.ReadLine());
            }

            Console.WriteLine(maxSequenceLenght);
        }
    }
}
