using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TwoSumTwoArraySorted
    {
        /*Approach
         * while numbers at left and right indexes don't equal target
         * increase the left pointer in result is less than target
         * decrease the right pointer if result is more than target
         */

        public int[] TwoSum(int[] numbers, int target)
        {
            var left = 0;
            var right = numbers.Length - 1;

            while (numbers[left] + numbers[right] != target) 
            {
                if (numbers[left] + numbers[right] < target) 
                    left++;
                else
                    right--;
            }
            return new int[] { left + 1, right + 1 };
        }
    }
}
