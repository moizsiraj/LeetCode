using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _01Matrix
    {
        //Not Solved
        public int[][] UpdateMatrix(int[][] mat)
        {
            var queue = new Queue<(int, int, int)>();
            var visited = new bool[mat.Length, mat[0].Length];
            var distance = new int[mat.Length][];

            for (int i = 0; i < distance.Length; i++)
            {
                distance[i] = new int[mat[0].Length];
            }

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 0) 
                    {
                        queue.Enqueue((i, j, 0));
                        visited[i, j] = true;
                    }
                }
            }

            var rows = new int[] { 0, 1, 0, -1 };
            var cols = new int[] { 1, 0, -1, 0 };
            while (queue.Count != 0)
            {
                var cell = queue.Dequeue();
                var row = cell.Item1;
                var col = cell.Item2;
                var step = cell.Item3;
                visited[row, col] = true;
                distance[row][col] = step;

                for (int i = 0; i < 4; i++)
                {
                    var temprow = row + rows[i];
                    var tempcol = col + cols[i];
                    if (temprow >= 0 && tempcol >= 0 && temprow < mat.Length && tempcol < mat[temprow].Length && !visited[temprow, tempcol])
                        queue.Enqueue((temprow, tempcol, step + 1));
                }
            }
            return distance;
        }
    }
}
