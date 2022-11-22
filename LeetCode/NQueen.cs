using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class NQueen
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var listOfList = new List<IList<string>>();
            var visited = new bool[n];
            var cells = new string[n, n];
            for (int i = 0; i < cells.Length; i++)
            {
                for (int j = 0; j < cells.Length; j++)
                {
                    cells[i, j] = ".";
                }
            }

            FillQueens(listOfList, cells, 0, visited);

            return listOfList;
        }

        private void FillQueens(List<IList<string>> listOfList, string[,] cells, int v, bool[] visited)
        {
            if (v > cells.Length)
            {
                var list = new List<string>();
                for (int i = 0; i < cells.Length; i++)
                {
                    var str = new StringBuilder();
                    for (int j = 0; j < cells.Length; j++)
                    {
                        str.Append(cells[i, j]);
                    }
                    list.Add(str.ToString());
                }
                listOfList.Add(list);
                return;
            }

            for (int i = 0; i < cells.Length; i++)
            {
                if (!RowHasAQueen(cells, i) && !ColHasAQueen(cells, v) && IsSafe(cells, i, v)) 
                {
                    cells[i, v] = "Q";
                    FillQueens(listOfList, cells, v + 1, visited);
                    cells[i, v] = ".";
                }
            }
        }

        private bool RowHasAQueen(string[,] cells, int row)
        {
            for (int i = 0; i < cells[row, 0].Length; i++)
            {
                if (cells[row, i] == "Q")
                    return true;
            }
            return false;
        }

        private bool ColHasAQueen(string[,] cells, int col)
        {
            for (int i = 0; i < cells.Length; i++)
            {
                if (cells[i, col] == "Q")
                    return true;
            }
            return false;
        }

        private bool IsSafe(string[,] cells, int row, int col)
        {
            var leftSafe = true;
            var rightSafe = true;
            var downSafe = true;
            var upSafe = true;
            var upLeftSafe = true;
            var upRightSafe = true;
            var downLeftSafe = true;
            var downRightSafe = true;

            var tempRow = row;
            var tempCol = col - 1;
            //check left
            while (tempCol >= 0)
            {
                if (cells[tempRow, tempCol] == "Q")
                {
                    leftSafe = false;
                    break;
                }
                tempCol--;
            }

            tempRow = row;
            tempCol = col + 1;
            //check right
            while (tempCol < cells[0, 0].Length)
            {
                if (cells[tempRow, tempCol] == "Q")
                {
                    rightSafe = false;
                    break;
                }
                tempCol++;
            }

            tempRow = row + 1;
            tempCol = col;
            //check down
            while (tempRow < cells.Length)
            {
                if (cells[tempRow, tempCol] == "Q")
                {
                    downSafe = false;
                    break;
                }
                tempRow++;
            }

            tempRow = row - 1;
            tempCol = col;
            //check up
            while (tempRow >= 0)
            {
                if (cells[tempRow, tempCol] == "Q")
                {
                    upSafe = false;
                    break;
                }
                tempRow--;
            }

            tempRow = row - 1;
            tempCol = col + 1;
            //check up right
            while (tempRow >= 0 && tempCol < cells[tempRow, 0].Length)
            {
                if (cells[tempRow, tempCol] == "Q")
                {
                    upRightSafe = false;
                    break;
                }
                tempRow--;
                tempCol++;
            }

            tempRow = row - 1;
            tempCol = col - 1;
            //check up left
            while (tempRow >= 0 && tempCol >= 0)
            {
                if (cells[tempRow, tempCol] == "Q")
                {
                    upLeftSafe = false;
                    break;
                }
                tempRow--;
                tempCol--;
            }

            tempRow = row + 1;
            tempCol = col + 1;
            //check down right
            while (tempRow < cells.Length && tempCol < cells[tempRow, 0].Length)
            {
                if (cells[tempRow, tempCol] == "Q")
                {
                    downRightSafe = false;
                    break;
                }
                tempRow++;
                tempCol++;
            }

            tempRow = row + 1;
            tempCol = col - 1;
            //check down left
            while (tempRow < cells.Length && tempCol >= 0)
            {
                if (cells[tempRow, tempCol] == "Q")
                {
                    upLeftSafe = false;
                    break;
                }
                tempRow++;
                tempCol--;
            }

            return upSafe && downSafe && rightSafe && leftSafe && upLeftSafe && upRightSafe && downLeftSafe && downRightSafe;
        }
    }
}
