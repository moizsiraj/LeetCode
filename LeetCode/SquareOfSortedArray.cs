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


        public int[] SortedSquaredArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * array[i];
            }

            var minIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                    minIndex = i;
            }

            var result = new int[array.Length];
            var left = minIndex - 1;
            var right = minIndex + 1;
            result[0] = array[minIndex];
            var counter = 1;
            
            while (left >= 0 && right < array.Length) 
            {
                result[counter] = array[left] <= array[right] ? array[left] : array[right];
                if (array[left] <= array[right])
                    left--;
                else
                    right++;
                counter++;
            }

            while (left >= 0) 
            {
                result[counter] = array[left];
                left--;
                counter++;
            }

            while (right < array.Length)
            {
                result[counter] = array[right];
                right++;
                counter++;
            }

            return result;
        }
    }
}
