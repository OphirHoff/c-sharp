using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    enum Direction { Left, Right , Up, Down}
    internal class Pacman
    {
        private int x;
        private int y;
        private Direction direction;
        
        public Pacman()
        {
            this.x = 0;
            this.y = 0;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        { 
            return this.y;
        }
            

        public void SetDirection(Direction direction)
        {
            this.direction = direction;
        }

        public Direction GetDirection()
        {
            return this.direction;
        }

        public void Move()
        {
            if (this.direction == Direction.Right)
                this.x++;

            else if (this.direction == Direction.Left)
                this.x--;
            else if (this.direction == Direction.Up)
                this.y--;
            else if (this.direction == Direction.Down)
                this.y++;
        }
    }
}
