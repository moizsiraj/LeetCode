using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MergeOverlappingInterval
    {
        /*Approach
         * sort the array so all the intervals are sorted
         * compare the last high of interval with next low
         * if last high is lower than current low, replace last high
         * with Max(this higher, last higher), else push the interval
         * in stack. at the end empty the stack into the result array
         */
        public int[][] MergeOverlappingIntervals(int[][] intervals)
        {
            var sorted = intervals.OrderBy(i => i[0]).ToList();
            var listOfArrays = new Stack<int[]>();
            listOfArrays.Push(sorted[0]);
            for (int i = 1; i < sorted.Count; i++)
            {
                var last = listOfArrays.Peek();
                var lasthigh = last[1];
                if (lasthigh >= sorted[i][0])
                    last[1] = sorted[i][1] < lasthigh ? lasthigh : sorted[i][1];
                else
                    listOfArrays.Push(sorted[i]);
            }
            var result = new int[listOfArrays.Count][];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = listOfArrays.Pop();
            }
            return result;
        }
    }
}
