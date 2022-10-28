using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FloodFills
    {
        /*My Approach
         * push the cells in a queue that need to be colored
         * for each cell, add it's left right bottom and top
         * cells into the queue. Maintain a visited 2D array
         * for keeping a check on visited cells
         */

        /*Easier Approach
         * solve recursively by checking the initial conditions and returing
         * just make recursive calls for each direction cell position
         * */

        //1 hour 10 mins
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            var queue = new Queue<(int, int)>();
            var visited = new bool[image.Length][];

            for (int i = 0; i < image.Length; i++)
            {
                visited[i] = new bool[image[i].Length];
            }

            var oldColor = image[sr][sc];
            queue.Enqueue((sr, sc));

            while (queue.Count != 0)
            {
                var cell = queue.Dequeue();
                if (image[cell.Item1][cell.Item2] == oldColor)
                {
                    image[cell.Item1][cell.Item2] = color;
                    visited[cell.Item1][cell.Item2] = true;
                }
                AddLeft();
                AddRight();
                AddTop();
                AddBottom();


                void AddBottom()
                {
                    if (cell.Item1 + 1 < image.Length && image[cell.Item1 + 1][cell.Item2] == oldColor)
                    {
                        if (!visited[cell.Item1 + 1][cell.Item2])
                            queue.Enqueue((cell.Item1 + 1, cell.Item2));
                    }
                }

                void AddTop()
                {
                    if (cell.Item1 - 1 >= 0 && image[cell.Item1 - 1][cell.Item2] == oldColor)
                        if (!visited[cell.Item1 - 1][cell.Item2])
                            queue.Enqueue((cell.Item1 - 1, cell.Item2));
                }

                void AddRight()
                {
                    if (cell.Item2 + 1 < image[cell.Item1].Length && image[cell.Item1][cell.Item2 + 1] == oldColor)
                        if (!visited[cell.Item1][cell.Item2 + 1])
                            queue.Enqueue((cell.Item1, cell.Item2 + 1));
                }

                void AddLeft()
                {
                    if (cell.Item2 - 1 >= 0 && image[cell.Item1][cell.Item2 - 1] == oldColor)
                        if (!visited[cell.Item1][cell.Item2 - 1])
                            queue.Enqueue((cell.Item1, cell.Item2 - 1));
                }
            }

            return image;
        }

        public int[][] FloodFillRecursiveStart(int[][] image, int sr, int sc, int color)
        {
            var oldColor = image[sr][sc];
            if(oldColor == color) return image;
            FloodFillRecurive(image, sr, sc, oldColor, color);
            return image;
        }

        public void FloodFillRecurive(int[][] image, int sr, int sc, int oldColor, int color)
        {
            if (sr < 0 || sc < 0 || sr >= image.Length || sc >= image[sr].Length || image[sr][sc] != oldColor)
                return;
            image[sr][sc] = color;
            FloodFillRecurive(image, sr, sc + 1, oldColor, color);
            FloodFillRecurive(image, sr, sc - 1, oldColor, color);
            FloodFillRecurive(image, sr + 1, sc, oldColor, color);
            FloodFillRecurive(image, sr - 1, sc, oldColor, color);
        }
    }
}
