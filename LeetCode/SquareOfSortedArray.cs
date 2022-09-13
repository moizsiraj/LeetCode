using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SquareOfSortedArray
    {
        /* My Approach
         * Square the array
         * find the middle point of the squared array
         * keep a left and right pointer of the middle
         * compare and start placing values in the result array
         */

        //1 hour
        public int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            SquareArray(nums);
            int middle = FindMiddleIndex(nums);
            FillResult(nums, result, middle);
            return result;
        }

        private void FillResult(int[] nums, int[]result, int middle)
        {
            var current = 0;
            result[current++] = nums[middle];
            var next = middle + 1;
            var prev = middle - 1;

            while (current < nums.Length  && prev >= 0 && next < nums.Length) 
            {
                if (nums[prev] > nums[next])
                {
                    result[current] = nums[next];
                    next++;
                }
                else 
                {
                    result[current] = nums[prev];
                    prev--;
                }
                current++;
            }
            while (current < nums.Length && next < nums.Length)
            {
                result[current++] = nums[next++];
            }
            while (current < nums.Length && prev >= 0)
            {
                result[current++] = nums[prev--];
            }
        }

        private int FindMiddleIndex(int[] nums)
        {
            var current = 0;
            var next = 1;

            while ((current < nums.Length - 1 && next < nums.Length) && nums[current] >= nums[next]) 
            { 
                current++;
                next++;
            }
            return current;
        }

        private void SquareArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
        }
    }
}
