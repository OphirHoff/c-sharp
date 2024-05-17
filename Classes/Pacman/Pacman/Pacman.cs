using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Pacman
    {
        private int x;
        private int y;
        private ConsoleColor fcolor;
        private ConsoleColor bcolor;
        private int maxX = 79;
        private int maxY = 24;
        
        // Constructor
        public Pacman()
        {
            this.x = 50;
            this.y = 20;
            this.fcolor = ConsoleColor.Black;
            this.bcolor = ConsoleColor.Yellow;
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.BackgroundColor = this.bcolor;
            Console.ForegroundColor = this.fcolor;
            Console.Write("O");
        }

        public void Undraw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
        }

        public void MoveUp()
        {
            if ((this.y - 1) >= 0)
            {
                Undraw();
                this.y--;
                Draw();
            }
        }

        public void MoveDown()
        {
            if ((this.y + 1) <= maxY)
            {
                Undraw();
                this.y++;
                Draw();
            }
        }

        public void MoveRight()
        {
            if ((this.x + 1) <= maxX)
            {
                Undraw();
                this.x++;
                Draw();
            }
        }

        public void MoveLeft()
        {
            if ((this.x - 1) >= 0)
            {
                Undraw();
                this.x--;
                Draw();
            }
        }

        
        
    }
}
