using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RemoveValue
    {
        /* Approach
         * Instead of removing val and placing it at the end
         * loop through the array and place all the valid nums
         * at the start of the array. keep a pointer for the valid
         * entries till where we place the valid values while looping
         */

        private int val;
        private int[] nums;

        public RemoveValue(int val, int[] nums)
        {
            this.val = val;
            this.nums = nums;
        }

        //10 Mins
        public int Solve()
        {
            if (nums.Length == 0) return 0;

            var valid_entries = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val) 
                {
                    nums[valid_entries] = nums[i];
                    valid_entries++;
                }
            }

            return valid_entries;
        }
    }
}
