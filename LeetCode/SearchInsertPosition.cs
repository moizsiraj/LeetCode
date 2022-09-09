using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SearchInsertPosition
    {
        /*My Approach
         * Similar approach to binary search
         * Remember to handle case of placement of target
         * before the first or after the last index
         */

        public int SearchInsert(int[] nums, int target)
        {
            return Search(nums, 0, nums.Length - 1, target);
        }

        //24 Mins
        private int Search(int[] nums, int start, int end, int target)
        {
            if (nums[^1] < target) return nums.Length;

            if (nums[0] > target) return 0;

            if (start == end)
            {
                if (nums[start] == target) return start;
                else return end;
            }

            int midpoint = start + ((end - start) / 2);
            if (nums[midpoint] >= target)
            {
                return Search(nums, start, midpoint, target);
            }
            else
            {
                return Search(nums, midpoint + 1, end, target);
            }
        }
    }
}
