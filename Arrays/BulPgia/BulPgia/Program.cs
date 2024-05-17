using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BulPgia
{
    class Program
    {
        public static bool IsRepeatingDigits(string num)
        {
            // Go over the 4 digits of the number
            for (int i = 0; i < num.Length; i++)
            {
                // for each digits check how many times is in the number
                char digit = num[i];

                int cnt = 0;
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[j] == digit)
                        cnt++;
                }
                if (cnt > 1)
                    return true;
            }
            return false;
        }

        // Print the number of Bul and number of Pgia of users guess
        public static bool PlayerGuessValue(string num, string guess)
        {
            int bul = 0;
            int hit = 0;

            for (int j = 0; j < guess.Length; j++)
            {
                // Check Bul
                if (guess[j] == num[j])
                    bul++;

                // Check Pgia
                else if (guess.Contains(num[j]))
                    hit++;
            }

            if (bul == 4)
            {
                Console.WriteLine("Exactly! Yeepee yay! You won!");
                return true;
            }

            else
            {
                Console.WriteLine("Bul: " + bul + ", " + "Hit: " + hit + ". Now my try!");
                return false;

            }
        }

        

        static void Main(string[] args)
        {

            BulHit game = new BulHit();
            Random rnd = new Random();

            Console.WriteLine("------- Let's play Bul Pgia! -------");
            Console.WriteLine("Choose a 4 digit number, and I'll too");
            Console.WriteLine("You start!");

            string PcNum = rnd.Next(10000).ToString("D4");
            while (IsRepeatingDigits(PcNum) == true)
                PcNum = rnd.Next(10000).ToString("D4");

            bool guessed = false;

            while (!guessed)
            {
                Console.Write("Your Guess (4 digit number): ");
                string playerGuess = Console.ReadLine();

                guessed = PlayerGuessValue(PcNum, playerGuess);

                Console.WriteLine();

                if (!guessed)
                {
                    game.RandomOption();
                    Console.WriteLine("Computer's guess: " + game.GetGuess());

                    // Get users response
                    Console.WriteLine("Enter Number of bul:");
                    int bul = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Number of hit:");
                    int hit = int.Parse(Console.ReadLine());

                    if (game.LessOptions(hit, bul) == true)
                    {
                        Console.WriteLine("Whoohoo! I won! Bad for you...");
                        guessed = true;
                    }
                }
                    
                Console.WriteLine();
            }

        }
    }
}
