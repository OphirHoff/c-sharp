using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TicTacToe
{

    class GameBoard
    {
        public void WriteFile(string fileName, string s)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(s);
            }
        }

        public string ReadFile(string fileName)
        {
            string s = "";
            using (StreamReader sr = new StreamReader(fileName))
            {
                s = sr.ReadLine();
                return s;
            }

        }



        private Cell[,] arr;

        public GameBoard()
        {
            this.arr = new Cell[3, 3];
            for (int i = 0; i < this.arr.GetLength(0); i++)
            {
                for (int j = 0; j < this.arr.GetLength(1); j++)
                {
                    arr[i, j] = new Cell(" ", i, j);
                }
            }
        }

        public void ClearBoard()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j].SetCellValue(" ");
                }
            }
        }

        public bool UserMove(int r, int c)
        {
            if (r < arr.GetLength(1) && c < arr.GetLength(0) && r >= 0 && c >= 0 && this.arr[r, c].GetCellValue() == " ")
            {
                this.arr[r, c].SetCellValue("O");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PCMove()
        {
            Random rnd = new Random();
            int row = rnd.Next(0, 3);
            int column = rnd.Next(0, 3);
            while (this.arr[row, column].GetCellValue() != " ")
            {
                row = rnd.Next(0, 3);
                column = rnd.Next(0, 3);
            }

            this.arr[row, column].SetCellValue("X");
        }

        public bool GameOver()
        {
            //Check row win
            for (int i = 0; i < this.arr.GetLength(0); i++)
            {
                if (arr[i, 0].GetCellValue() == "X" && arr[i, 1].GetCellValue() == "X" && arr[i, 2].GetCellValue() == "X")
                    return true;
                else if
                    (arr[i, 0].GetCellValue() == "O" && arr[i, 1].GetCellValue() == "O" && arr[i, 2].GetCellValue() == "O")
                    return true;
            }

            // Check column win
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[0, i].GetCellValue() == "X" && arr[1, i].GetCellValue() == "X" && arr[2, i].GetCellValue() == "X")
                    return true;
                else if (arr[0, i].GetCellValue() == "O" && arr[1, i].GetCellValue() == "O" && arr[2, i].GetCellValue() == "O")
                    return true;
            }

            //Check diagnol win
            if (arr[0, 0].GetCellValue() == "X" && arr[1, 1].GetCellValue() == "X" && arr[2, 2].GetCellValue() == "X")
                return true;
            else if (arr[0, 2].GetCellValue() == "X" && arr[1, 1].GetCellValue() == "X" && arr[2, 0].GetCellValue() == "X")
                return true;
            if (arr[0, 0].GetCellValue() == "O" && arr[1, 1].GetCellValue() == "O" && arr[2, 2].GetCellValue() == "O")
                return true;
            else if (arr[0, 2].GetCellValue() == "O" && arr[1, 1].GetCellValue() == "O" && arr[2, 0].GetCellValue() == "O")
                return true;

            bool full = true;
            for (int i = 0; i < arr.GetLength(0) && full; i++)
            {
                for (int j = 0; j < arr.GetLength(1) && full; j++)
                {
                    if (arr[i, j].GetCellValue() == " ")
                    {
                        full = false;
                    }
                }
            }
            return full;
        }


        public void Print()
        {
            Console.WriteLine(ReadFile("c://a.txt"));
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j].GetCellValue() + " | ");
                }
                Console.WriteLine();
                for (int x = 0; x < arr.GetLength(1); x++)
                {
                    Console.Write("----");
                }
                Console.WriteLine();
            }
        }

    }
}
