using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SpiralTraversal
    {
        /*Approach
         *think of the stairs as multiple parameters
         *take 4 starting points starting row, starting column
         *ending row, ending column. read elements in spiral
         *using for loops and these limits
         */
        public List<int> SpiralTraverse(int[,] array)
        {
            var result = new List<int>();
            var sr = 0;
            var sc = 0;
            var er = array.GetLength(0) - 1;
            var ec = array.GetLength(1) - 1;

            while (sr < er && sc < ec) 
            {
                FillArray(result, array, sc, ec, sr, er);
                sc++;
                ec--;
                sr++;
                er--;
            }

            if (er == sr && sc != ec) 
            {
                for (int i = sc; i <= ec; i++)
                {
                    result.Add(array[er, i]);
                }
            }

            if (er != sr && sc == ec)
            {
                for (int i = sr; i <= er; i++)
                {
                    result.Add(array[i, sc]);
                }
            }

            if (er == sr && sr == sc && sc == ec) 
            {
                result.Add(array[er, ec]);
            }

            return result;
        }

        private static void FillArray(List<int> result, int[,] array, int sc, int ec, int sr, int er)
        {
            for (int i = sc; i <= ec; i++)
            {
                result.Add(array[sr,i]);
            }

            for (int i = sr + 1; i <= er; i++)
            {
                result.Add(array[i, ec]);
            }

            for (int i = ec - 1; i >= sc; i--)
            {
                result.Add(array[er, i]);
            }

            for (int i = er - 1; i >= sr + 1; i--)
            {
                result.Add(array[i, sc]);
            }
        }
    }
}
