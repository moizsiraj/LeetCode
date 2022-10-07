using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaxiumSubArray
    {
        public int MaxSubArrayN3(int[] nums)
        {
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    int sum = 0;
                    for (int k = i; k <= j; k++)
                    {
                        sum += nums[k];
                    }
                    if (max < sum)
                        max = sum;
                }
            }
            return max;
        }

        public int MaxSubArrayN2(int[] nums)
        {
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (max < sum)
                        max = sum;
                }
            }
            return max;
        }

        public int MaxSubArrayN(int[] nums)
        {
            int max = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (max < sum)
                    max = sum;
                if(sum < 0)
                    sum = 0;
            }
            return max;
        }
    }
}
