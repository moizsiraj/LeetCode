using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            ReverseOriginalList(nums);
            ReverseFirstKNums(nums, k);
            ReverseNextNMinusKNums(nums, k);
        }

        private void ReverseNextNMinusKNums(int[] nums, int k)
        {
            int start = k;
            int end = nums.Length - 1;

            Reverse(nums, ref start, ref end);
        }

        private void ReverseFirstKNums(int[] nums, int k)
        {
            int start = 0;
            int end = k - 1;

            Reverse(nums, ref start, ref end);
        }

        private void ReverseOriginalList(int[] nums)
        {
            int start = 0;
            int end  = nums.Length - 1;

            Reverse(nums, ref start, ref end);
        }

        private static void Reverse(int[] nums, ref int start, ref int end)
        {
            while (start < end)
            {
                var temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
