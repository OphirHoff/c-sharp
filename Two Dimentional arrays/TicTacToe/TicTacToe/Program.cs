using System;
using System.IO;
using System.Threading;

namespace TicTacToe
{
    internal class Program
    {
        public static void WriteFile(string fileName, string s)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(s);
            }
        }

        public static string ReadFile(string fileName)
        {
            string s = "";
            using (StreamReader sr = new StreamReader(fileName))
            {
                s = sr.ReadLine();
                return s;
            }
            
        }


        static void Main(string[] args)
        {

            GameBoard board = new GameBoard();

            bool cont = true;
            while (cont)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                board.Print();

                // User Turn
                Console.WriteLine("Enter coordinates");
                int row = int.Parse(Console.ReadLine());
                int column = int.Parse(Console.ReadLine());
                //Check For Error
                while (!board.UserMove(row, column))
                {
                    Console.WriteLine("ERROR!!!!");
                    Console.SetCursorPosition(0, 0);
                    board.Print();
                    Console.WriteLine("Enter coordinates");
                    row = int.Parse(Console.ReadLine());
                    column = int.Parse(Console.ReadLine());
                }

                Console.Clear();
                Console.SetCursorPosition(0, 0);
                board.Print();

                if (board.GameOver() == true)
                {
                    Console.WriteLine("You Won! GOOD GAME!");
                    string score = ReadFile("c://a.txt");
                    int newScore = int.Parse(score.Substring(0, 1));
                    newScore++;
                    WriteFile("c://a.txt", newScore + "" + score.Substring(1));
                    cont = false;

                }

                if (cont)
                {
                    // PC's Turn
                    Console.WriteLine("PC thinks.....");
                    Thread.Sleep(2000);
                    board.PCMove();
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    board.Print();

                    if (board.GameOver())
                    {
                        Console.WriteLine("GOOD OVER! GOOD GAME!");
                        string score = ReadFile("c://a.txt");
                        int newScore = int.Parse(score.Substring(2));
                        newScore++;
                        WriteFile("c://a.txt", score.Substring(0,1) + "" + newScore);
                        cont = false;
                        cont = false;

                    }
                }

            }
        }
    }
}
