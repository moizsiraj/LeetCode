//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode
//{
//    internal class TheMaze
//    {
//         Not Solved
//        public bool TheMaze(int[][] maze, int[] start, int[] destination)
//        {
//            var visited = new bool[maze.Length][];
//            for (int i = 0; i < visited.Length; i++)
//            {
//                visited[i] = new bool[maze[i].Length];
//            }

//            for (int i = start[0]; i < maze.Length; i++)
//            {
//                for (int j = start[1]; j < maze[i].Length; j++)
//                {
//                    if (PathExist(maze, visited, i, j, destination[0], destination[1], 'D'))
//                        return true;
//                }
//            }

//            return false;
//        }

//        private bool PathExist(int[][] maze, bool[][] visited, int i, int j, int destRow, int destCol, char direction)
//        {
//            if (i == destRow && j == destCol && CanStop(maze, i, j, direction))
//                return true;
//            if (visited[i][j] || maze[i][j] == 0 || !RowValid(maze, i) || !ColValid(maze, i, j))
//                return false;

//            visited[i][j] = true;
//            var down = true;
//            var up = true;
//            var left = true;
//            var right = true;

//            if (direction == 'D')
//            {
//                while (down && i != destRow && j != destCol) 
//                {
//                    down = down && PathExist(maze, visited, i + 1, j, destRow, destCol, 'D');
//                }
//                if(i == destRow && j == destCol)
//                    return true;
//                else

//            }

//            if (direction == 'U')
//            {
//                while (up && i != destRow && j != destCol)
//                {
//                    up = up && PathExist(maze, visited, i - 1, j, destRow, destCol, 'U');
//                }
//                if (i == destRow && j == destCol)
//                    return true;
//            }

//            if (direction == 'D')
//            {
//                while (down && i != destRow && j != destCol)
//                {
//                    down = down && PathExist(maze, visited, i + 1, j, destRow, destCol, 'D');
//                }
//                if (i == destRow && j == destCol)
//                    return true;
//            }

//            if (direction == 'D')
//            {
//                while (down && i != destRow && j != destCol)
//                {
//                    down = down && PathExist(maze, visited, i + 1, j, destRow, destCol, 'D');
//                }
//                if (i == destRow && j == destCol)
//                    return true;
//            }
//        }

//        private bool CanStop(int[][] maze, int i, int j, char direction)
//        {
//            if (RowValid(maze, i) && ColValid(maze, i, j))
//            {
//                if (direction == 'D' && RowValid(maze, i + 1))
//                    return maze[i + 1][j] == 0;
//                else if (direction == 'U' && RowValid(maze, i - 1))
//                    return maze[i - 1][j] == 0;
//                else if (direction == 'L' && ColValid(maze, i, j - 1))
//                    return maze[i][j - 1] == 0;
//                else if (direction == 'R' && ColValid(maze, i, j + 1))
//                    return maze[i][j + 1] == 0;
//                else
//                    return false;
//            }
//            return false;
//        }

//        private bool ColValid(int[][] maze, int i, int j)
//        {
//            throw new NotImplementedException();
//        }

//        private bool RowValid(int[][] maze, int i)
//        {
//            return i >= 0 && i < maze.Length;
//        }
//    }
//}
