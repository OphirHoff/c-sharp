using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsNodes
{
    class Card
    {
        private int num;
        private string color;

        public Card(int num, string color)
        {
            this.num = num;
            this.color = color;
        }

        public int GetNum()
        {
            return this.num;
        }

        public string GetColor()
        {
            return this.color;
        }

        public override string ToString()
        {
            return this.num + "," + this.color;
        }
    }
}
