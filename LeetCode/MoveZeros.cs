using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MoveZeros
    {
        /* My Approach
         * Current points to first 0
         * Next points to the first non 0 after the current
         * swap current with next
         * continue until current and next are less than lenght
         * */

        /*Shorter Approach
         * traverse the array filling it with the non zero values
         * keeping a pointer for the index that has been last filled
         * with a non zero value. fill the array with zeros starting 
         * from the index pointer till the end
         * */

        //49 Mins
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length == 1) return;

            var current = 0;

            while (nums[current] != 0)
            {
                current++;
                if (current >= nums.Length)
                {
                    return;
                }
            }

            var next = current + 1;

            while (next < nums.Length && nums[next] == 0)
            {
                next++;
                if (next >= nums.Length)
                {
                    return;
                }
            }


            while (current < nums.Length && next < nums.Length)
            {
                var temp = nums[next];
                nums[next] = nums[current];
                nums[current] = temp;

                while (current < nums.Length && nums[current] != 0)
                    current++;

                while (next < nums.Length && nums[next] == 0)
                    next++;
            }
        }

        public void MoveZeroesShorter(int[] nums)
        {
            var index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) 
                    nums[index++] = nums[i];
            }

            for (int i = index; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
