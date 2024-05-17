using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Ball
    {
        private int x;
        private int y;
        private int maxX = 79;
        private int maxY = 26;
        private char ch = 'O';

        // Directions
        enum Direction { UpRight, DownLeft, DownRight, UpLeft};
        private Direction direction;
        
        //Constructor
        public Ball(int direction)
        {
            this.direction = (Direction)direction;
            this.x = 40;
            this.y = 12;
        }

        public int GetY()
        {
            return this.y;
        }

        public int GetX()
        {
            return this.x;
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(ch);
        }

        public void Undraw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" ");
        }

        // change direction for when hits the borders up or down
        public void ChangeDirectionY()
        {
            this.direction = (Direction)(((int)this.direction + 2) % 4);
        }

        // change direction for when hits the left or right borders
        public void ChangeDirectionX()
        {
            if ((int)this.direction == 0)
                this.direction = (Direction)3;
            else if ((int)this.direction == 1)
                this.direction = (Direction)2;
            else if ((int)this.direction == 2)
                this.direction = (Direction)1;
            else if ((int)this.direction == 3)
                this.direction = (Direction)0;
        }

        // Move ball
        public bool Move(bool b)
        {
            // parameter if ball about to hit a tile
            bool hitTile = b;

            if (this.direction == Direction.UpRight)
            {
                //if about to hit a tile
                if (hitTile == true)
                {
                    this.ChangeDirectionX();
                    Move(false);
                    return true;
                }

                // if ball not about to hit anything
                else if ((this.y - 1 >= 0) && (this.x + 1 <= maxX))
                {
                    Undraw();
                    this.y--;
                    this.x++;
                    Draw();
                    return true;
                }
                //if about to hit up or down borders
                else if (this.y - 1 < 0)
                {
                    this.ChangeDirectionY();
                    Move(false);
                    return true;
                }

                

                else
                    return false;

            }

            else if (this.direction == Direction.UpLeft)
            {
                if (hitTile == true)
                {
                    ChangeDirectionX();
                    Move(false);
                    return true;
                }

                else if ((this.y - 1 >= 0) && (this.x - 1 >= 5))
                {
                    Undraw();
                    this.y--;
                    this.x--;
                    Draw();
                    return true;
                }
                else if (this.y - 1 < 0)
                {
                    this.ChangeDirectionY();
                    Move(false);
                    return true;
                }
                

                else
                    return false;
            }

            else if (this.direction == Direction.DownRight)
            {
                if (hitTile == true)
                {
                    this.ChangeDirectionX();
                    Move(false);
                    return true;
                }

                else if ((this.y+1  <= maxY) && (this.x  < maxX))
                {
                    Undraw();
                    this.x++;
                    this.y++;
                    Draw();
                    return true;
                }
                else if (this.y + 1 > maxY)
                {
                    this.ChangeDirectionY();
                    Move(false);
                    return true;
                }
                

                else
                    return false;
            }

            else
            {
                if (hitTile == true)
                {
                    this.ChangeDirectionX();
                    Move(false);
                    return true;
                }

                else if ((this.y + 1 <= maxY) && (this.x - 1 >= 5))
                {
                    Undraw();
                    this.x--;
                    this.y++;
                    Draw();
                    return true;
                }
                else if (this.y + 1 > maxY)
                {
                    this.ChangeDirectionY();
                    Move(false);
                    return true;
                }
                

                else
                    return false;
            }

            
        }
    }
}
