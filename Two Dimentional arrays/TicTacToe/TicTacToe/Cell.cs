using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Cell
    {
        private string cellValue;
        private int row;
        private int column;

        public Cell()
        {
            
        }

        public Cell(string value, int row, int column)
        {
            this.cellValue = value;
            this.row = row;
            this.column = column;
        }

        public void SetCellValue(string s)
        {
            cellValue = s;
        }

        public string GetCellValue()
        {
            return this.cellValue;
        }

        public void SetRow(int r)
        {
            this.row = r;
        }

        public int GetRow()
        {
            return this.row;
        }

        public void SetColumn (int c)
        {
            this.column = c;
        }

        public int GetColumn()
        {
            return this.column;
        }

    }
}
