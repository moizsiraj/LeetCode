using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class BinarySearch
    {
        /* My Approach
         * Recurvive Search where in each recursive call we send
         * a updated start or end index based on the mid index value
         * where min index is calculated by taking average of end and start
         * until start and end are equal. We do a final check at this point
         * if target is equal to arr[start] return start else -1
         */

        /*Important point
         * Addition of start and end can over flow the integer limit
         * a better approach is to find the difference between end and start
         * and then add it to start
         */

        //38 Mins
        public int Search(int[] nums, int target)
        {
            if (nums[0] <= target && nums[^1] >= target)
            {
                return Search(nums, 0, nums.Length - 1, target);
            }
            else
            {
                return -1;
            }
        }

        private int Search(int[] values, int startIndex, int endIndex, int target)
        {
            int mid = (startIndex + endIndex) / 2;

            if (startIndex == endIndex)
            {
                if (values[startIndex] == target)
                    return startIndex;
                else
                    return -1;
            }

            if (values[mid] == target)
                return mid;
            else if (values[mid] < target)
            {
                return Search(values, mid + 1, endIndex, target);
            }
            else
            {
                return Search(values, startIndex, mid, target);
            }
        }
    }
}
