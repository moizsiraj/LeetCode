using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LongestPeaks
    {
        /*Apprach
         * find peaks by finding elements that have a smaller element
         * on the left and right. keep increasing the left and right pointer
         * until the next of this pointer is higher. return the highest peak.
         */
        public static int LongestPeak(int[] array)
        {
            var max = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                var left = i - 1;
                var right = i + 1;

                if (array[left] < array[i] && array[i] > array[right]) 
                {
                    while(left >= 0 && array[left] < array[left + 1])
                        left--;
                    while (right < array.Length && array[right] < array[right - 1])
                        right++;

                    var peak = right - left + 1;
                    if (peak > max)
                        max = peak;
                }
            }
            return max;
        }
    }
}
