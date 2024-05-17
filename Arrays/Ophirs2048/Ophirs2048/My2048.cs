using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ophirs2048
{
    class My2048
    {
        private int[] arr;
        private int score;
        public enum Direction { Right, Left};
        public Direction direction;
        Random rnd = new Random();

        public My2048(int size)
        {
            this.arr = new int[size];
            this.score = 0;
            AddNum();
        }

        private void AddNum()
        {
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    cnt++;
            }

            int InsertIndex = rnd.Next(1, cnt + 1);

            int num;
            int grill = rnd.Next(101);
            if (grill >= 0 && grill <= 85)
                num = 2;
            else
                num = 4;

            int zeroCnt = 1;
            bool cont = true;
            for (int i = 0; i < arr.Length && cont; i++)
            {
                if (arr[i] == 0)
                {
                    if (zeroCnt == InsertIndex)
                    {
                        arr[i] = num;
                        cont = false;
                    }

                    else
                        zeroCnt++;
                }
            }
        }

        public void Draw()
        {
            int xpos = 2;
            int ypos = 2;
            for (int i = 0; i < arr.Length; i++)
            {
                Trect rec = new Trect(xpos, ypos - 1, 6, 3, ConsoleColor.Blue);
                rec.Draw();
                if (arr[i] == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else if (arr[i] == 4)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else if (arr[i] == 8)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else if (arr[i] == 16)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else if (arr[i] == 32)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else if (arr[i] == 64)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if (arr[i] == 128)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                }
                else if (arr[i] == 256)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                }
                else if (arr[i] == 512)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }
                else if (arr[i] == 1024)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else if (arr[i] == 2048)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(xpos + 1, ypos);
                if (arr[i] > 0)
                    Console.Write("{0, 4}", arr[i]);
                else
                    Console.Write("    ");
                xpos += 8;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        public bool MoveLeft()
        {
            int index = 0;
            bool changed = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    changed = true;
                    int save = arr[i];
                    arr[i] = arr[index];
                    arr[index] = save;
                    index++;
                }
            }
            return changed;
        }

        public bool MoveRight()
        {
            int index = arr.Length-1;
            bool changed = false;
            for (int i = arr.Length-1; i >= 0; i--)
            {
                if (arr[i] != 0)
                {
                    changed = true;
                    int save = arr[i];
                    arr[i] = arr[index];
                    arr[index] = save;
                    index--;
                }
            }
            return changed;
        }

        public void RightMerge()
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i+1] && arr[i] != 0)
                {
                    arr[i + 1] *= 2;
                    arr[i] = 0;
                    i++;
                }
            }
        }

        public void LeftMerge()
        {
            for (int i = arr.Length-1; i > 0; i--)
            {
                if (arr[i] == arr[i-1] && arr[i] != 0)
                {
                    arr[i - 1] *= 2;
                    arr[i] = 0;
                    i--;
                }
            }
        }

        public bool Right2048()
        {
            int[] check = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                check[i] = arr[i];
            }
            MoveRight();
            RightMerge();
            MoveRight();
            AddNum();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != check[i])
                    return true;
            }
            return false;
        }

        public bool Left2048()
        {
            int[] check = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                check[i] = arr[i];
            }
            MoveLeft();
            LeftMerge();
            MoveLeft();
            AddNum();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != check[i])
                    return true;
            }
            return false;
        }

        public bool Move2048(Direction direction)
        {
            if (direction == Direction.Left)
                return Left2048();
            else
                return Right2048();
        }
    }
}
