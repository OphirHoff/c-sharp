using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class ItemMrtn
    {
        private int year;
        private int score;

        public ItemMrtn(int year, int score)
        {
            this.year = year;
            this.score = score;
        }

        public int GetYear()
        {
            return this.year;
        }

        public int GetScore()
        {
            return this.score;
        }
    }
}
