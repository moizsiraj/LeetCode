using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RottingOranges
    {
        public int OrangesRotting(int[][] grid)
        {
            var queue = new Queue<(int, int, int)>();
            var visited = new bool[grid.Length, grid[0].Length];

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        queue.Enqueue((i, j, 2));
                        visited[i, j] = true;
                    }
                }
            }
            var minutes = 0;
            var deltaRow = new int[4] { 0, 0, 1, -1 };
            var deltaCol = new int[4] { 1, -1, 0, 0 };
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                var nodeRow = node.Item1;
                var nodeCol = node.Item2;
                var val = node.Item3;
                var willRot = false;
                for (int i = 0; i < 4; i++)
                {
                    var tempRow = nodeRow + deltaRow[i];
                    var tempCol = nodeCol + deltaCol[i];

                    if (tempRow >= 0 && tempCol >= 0 && tempRow < grid.Length && tempCol < grid[0].Length && !visited[tempRow, tempCol] && grid[tempRow][tempCol] == 1)
                    {
                        willRot = true;
                        visited[tempRow, tempCol] = true;
                        queue.Enqueue((tempRow, tempCol, 1));
                    }
                }

                if (willRot) minutes++;
            }

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (!visited[i, j] && grid[i][j] == 1)
                    {
                        return -1;
                    }
                }
            }

            return minutes;
        }
    }
}
