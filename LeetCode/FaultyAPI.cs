using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FaultyAPI
    {
        /*My Approach
         * Recurively find the mid point and check if it's bad
         * if bad set the midpoint as end as we are sure that its
         * bad till this point. If its not bad set start as mid + 1
         * to check if the bad ones start from the next.
         * MAJOR LEARNING : Trust the algo to handle the corner cases,
         * check for other issues that might cause the problems in 
         * corner cases
         */

        public int FirstBadVersion(int n)
        {
            return search(1, n);
        }

        //2+ hours (silly oversight)
        private int search(int start, int end)
        {
            if (start == end) 
            {
                if (IsBadVersion(start)) return start;
                else return -1;
            }

            int faulty = start + ((end - start)/2);
            if (IsBadVersion(faulty))
            {
                return search(start, faulty);
            }
            else
            {
                return search(faulty + 1, end);
            }
        }
    }
}
