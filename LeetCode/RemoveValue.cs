using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RemoveValue
    {
        private int val;
        private int[] nums;

        public RemoveValue(int val, int[] nums)
        {
            this.val = val;
            this.nums = nums;
        }

        public int Solve()
        {
            if ((nums.Length == 0) || nums.Length == 1 && nums[0] == val) return 0;
            if(nums.Length == 1 && nums[0] != val) return 1;

            int current = 0;
            int next = 1;

            while (next < nums.Length) 
            {
                if (nums[current] == val) 
                {
                    while (nums[next] == val) 
                    {
                        next++;
                        if (next >= nums.Length)
                            return current;
                    }
                    nums[current] = nums[next];
                }
                current++;
                next++;

            }
            return current;
        }
    }
}
