using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseAString
    {
        /*My Approach
         * simple swaps
         */

        //6 Mins
        public void ReverseString(char[] s)
        {
            var left = 0;
            var right = s.Length - 1;

            while (left < right) 
            {
                (s[left], s[right]) = (s[right], s[left]);
                left++;
                right--;
            }
        }
    }
}
