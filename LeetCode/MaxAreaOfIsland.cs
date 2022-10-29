using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaxAreaOfIsland
    {
        /*Approach
         * traverse the whole grid and make recursive calls for all the 
         * cells get the island size making recursive calls in 4 direction
         */
        //54 Mins
        public int maxAreaOfIsland(int[][] grid)
        {
            var visited = new bool[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                visited[i] = new bool[grid[i].Length];
            }

            var max = int.MinValue;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    //ResetVisited();
                    var sum = maxAreaAroundCell(grid, i, j, visited);
                    if (sum > max)
                        max = sum;
                }
            }
            return max;

            //reseting not needed as if one island is visited once
            //there is no need to visit it again as it and it's surrounding
            //is already covered
            void ResetVisited() 
            {
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        visited[i][j] = false;
                    }
                }
            }
        }

        private int maxAreaAroundCell(int[][] grid, int sr, int sc, bool[][] visited) 
        {
            if(sc < 0 || sr < 0 || sr >= grid.Length || sc >= grid[sr].Length || grid[sr][sc] == 0 || visited[sr][sc])
                return 0;
            var sum = 1;
            visited[sr][sc] = true;
            sum += maxAreaAroundCell(grid, sr + 1, sc, visited);
            sum += maxAreaAroundCell(grid, sr - 1, sc, visited);
            sum += maxAreaAroundCell(grid, sr, sc + 1, visited);
            sum += maxAreaAroundCell(grid, sr, sc - 1, visited);
            return sum;
        }
    }
}
