using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RemoveDuplicate
    {
        /* My Approach*/
        /*
         * Use 2 pointers next and current
         * move next until you see a unique character
         * fill the array from current + 1 till the next unique character
         * return when next >= length and when the loop ends
         * */

        /*Optimal Approach
         * same as mine but there is on need to fill the array
         * just move the pointer forward
         */

        private int[] nums;

        public RemoveDuplicate(int[] nums)
        {
            this.nums = nums;
        }

        // 20 Mins
        public int Solve() 
        {
            if (nums.Length < 2)
                return nums.Length;
            int next = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (next >= nums.Length)
                    return i;
                if (nums[i] == nums[next]) 
                {
                    while (next < nums.Length && nums[i] == nums[next])
                        next++;
                    for (int j = i + 1; j < next && next < nums.Length; j++)
                        nums[j] = nums[next];
                }
            }
            return nums.Length;
        }
    }
}
