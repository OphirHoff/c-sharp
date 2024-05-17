using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AIRow
{
    class Program
    {
        static void Main(string[] args)
        {
            AIRow game = new AIRow(13);
            game.NewGame();


            Console.WriteLine("1 = Player ...You. ");
            Console.WriteLine("2 = Computer");
            Console.WriteLine("Winner = sequence of " + game.GetLen());
            Console.WriteLine("MAx Minimax Depth   = " + game.GetDepth() );
            Console.WriteLine("Use Arrows for move.");
            Console.WriteLine("Use Spcae to put 1 in location");
            
            bool PlayerTurn = true;
            ConsoleKey key = 0;
            bool win = false;
            game.PrintRow();


            bool inGame = true;
            while (inGame)
            {
                if (PlayerTurn && !game.NoMoveLeft())
                {
                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey().Key;
                        if (key == ConsoleKey.LeftArrow || key == ConsoleKey.RightArrow)
                            game.PlayerMoveCursor(key);
                        else if (key == ConsoleKey.Q)
                            inGame = false;
                        else if (key == ConsoleKey.Spacebar)
                        {
                            bool Player_moved = game.DoPlayerMove();
                            if (Player_moved)
                            {
                                PlayerTurn = false;
                                win = game.CheckWin();
                                if (win)
                                    inGame = false;
                            }
                        }
                    }
                }
                else if (!PlayerTurn && !game.NoMoveLeft())
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("PC Think ...");
                    Console.ForegroundColor = ConsoleColor.White;
                    game.DoPCMove();
                    Console.WriteLine("\r PC Done !");
                    win = game.CheckWin();
                    if (win)
                        inGame = false;
                    PlayerTurn = true;
                }

                if (game.NoMoveLeft() && !win)
                {
                    Console.WriteLine("  --  Tie  -- ");
                    Console.WriteLine();
                    inGame = false;
                }
                game.PrintRow();
                Thread.Sleep(50);
                if (game.NoMoveLeft())
                    inGame = false;
            }
            Console.WriteLine("\nEND. Press any key");
            Console.ReadKey();
        }
    }
}
