using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class NumberOf1Bits
    {
        /*Approach
         * Consume and count 1s
         */

        //25 Mins
        public int HammingWeight(uint n)
        {
            var count = 0;
            while (n != 1 && n != 0) 
            {
                if(n % 2 == 1)
                    count++;
                n = n >> 1;
            }
            if(n == 1) count++;
            return count;
        }
    }
}
