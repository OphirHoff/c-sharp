using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Shape
    {

        private int height;
        private int width;
        private int x;
        private int y;
        private string ch = "██";
        private ConsoleColor fcolor;
        private int shapeNum;
        enum Direction { up, right, down, left};
        private Direction direction;

        

        public Shape(int shapeNum)
        {
            this.x = 39;
            this.y = 0;
            this.direction = 0;
            this.shapeNum = shapeNum;
            this.fcolor = ConsoleColor.White;

            if (this.shapeNum == 1)
            {
                this.height = 2;
                this.width = 3;
            }

            if (this.shapeNum == 2)
            {
                this.height = 2;
                this.width = 3;
            }

            if (this.shapeNum == 3)
            {
                this.height = 2;
                this.width = 2;
            }
            
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            if (this.shapeNum == 1)
            {
                if ((int)direction == 0 || (int)direction == 2)
                {
                    Console.Write(ch + ch);
                    Console.SetCursorPosition(this.x + 2, this.y + 1);
                    Console.Write(ch + ch);
                }
                else if ((int)direction == 1 || (int)direction == 3)
                {
                    Console.SetCursorPosition(this.x + 2, this.y);
                    Console.Write(ch);
                    Console.SetCursorPosition(this.x, this.y + 1);
                    Console.Write(ch + ch);
                    Console.SetCursorPosition(this.x, this.y + 2);
                    Console.Write(ch);
                }
            }

            else if (this.shapeNum == 2)
            {
                if ((int)direction == 0 || (int)direction == 2)
                {
                    Console.SetCursorPosition(this.x + 2, this.y);
                    Console.Write(ch + ch);
                    Console.SetCursorPosition(this.x, this.y + 1);
                    Console.Write(ch + ch);
                }
                else if ((int)(direction) ==  1 || (int)direction == 3)
                {
                    Console.SetCursorPosition(this.x, this.y);
                    Console.Write(ch);
                    Console.SetCursorPosition(this.x, this.y + 1);
                    Console.Write(ch + ch);
                    Console.SetCursorPosition(this.x + 2, this.y + 2);
                    Console.Write(ch);
                }
            }

            else if (this.shapeNum == 3)
            {
                Console.Write(ch + ch + ch);
                Console.SetCursorPosition(this.x, this.y + 1);
                Console.Write(ch);
            }
        }

        public void Undraw()
        {
            Console.SetCursorPosition(this.x, this.y);
            if (this.shapeNum == 1)
            {
                if ((int)direction == 0 || (int)direction == 2)
                {
                    Console.Write("    ");
                    Console.SetCursorPosition(this.x + 2, this.y + 1);
                    Console.Write("    ");
                }
                if ((int)direction == 1 || (int)direction == 3)
                {
                    Console.SetCursorPosition(this.x + 2, this.y);
                    Console.Write("  ");
                    Console.SetCursorPosition(this.x, this.y + 1);
                    Console.Write("    ");
                    Console.SetCursorPosition(this.x, this.y + 2);
                    Console.Write("  ");
                }
            }

            else if (this.shapeNum == 2)
            {
                if ((int)direction == 0 || (int)direction == 2)
                {
                    Console.SetCursorPosition(this.x + 2, this.y);
                    Console.Write("    ");
                    Console.SetCursorPosition(this.x, this.y + 1);
                    Console.Write("    ");
                }
                else if ((int)(direction) == 1 || (int)direction == 3)
                {
                    Console.SetCursorPosition(this.x, this.y);
                    Console.Write("  ");
                    Console.SetCursorPosition(this.x, this.y + 1);
                    Console.Write("    ");
                    Console.SetCursorPosition(this.x + 2, this.y + 2);
                    Console.Write("  ");
                }
            }

            else if (this.shapeNum == 3)
            {
                Console.Write("      ");
                Console.SetCursorPosition(this.x, this.y + 1);
                Console.Write("      ");
            }
        }

        

        public void Turn()
        {
            if ((int)direction < 3)
            {
                Undraw();
                direction++;
            }
            else
            {
                Undraw();
                direction = Direction.up;
            }
            Draw();
        }

        public void MoveDown()
        {
            if ((this.y + height) <= 25)
            {
                Undraw();
                this.y++;
                Draw();
            }
        }

        public bool IsMoving()
        {
            if ((this.y + height) <= 25)
            {
                return true;
            }
            return false;
        }
    }
}
