using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Tiles
    {
        private int side; //1-right, 2-left
        private int x;
        private int y;
        private int height;
        private int maxY = 25;

        public Tiles(int side)
        {
            this.side = side;
            this.height = 7;
            this.y = 12;
            
            if(this.side == 1)
            {
                this.x = 80;
            }

            else if(this.side == 2)
            {
                this.x = 5;
            }

        }

        public void Draw()
        {
            int GibuiY = this.y-3;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;

            for (int h = 1; h <= this.height; h++)
            {
                Console.SetCursorPosition(this.x, GibuiY);
                Console.Write("█");
                GibuiY++;
            }
        }

        public void Undraw()
        {
            int GibuiY = this.y - 3;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            for (int h = 1; h <= this.height; h++)
            {
                Console.SetCursorPosition(this.x, GibuiY);
                Console.Write(" ");
                GibuiY++;
            }
        }

        public int GetY()
        {
            return this.y;
        }

        public int GetX()
        {
            return this.x;
        }

        public void MoveUp()
        {
            if (this.y-4 >= 0)
            {
                Undraw();
                this.y--;
                Draw();
            }
        }

        public void MoveDown()
        {
            if (this.y+4 <= maxY)
            {
                Undraw();
                this.y++;
                Draw();
            }
        }
    }
}
