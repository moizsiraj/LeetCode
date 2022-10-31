using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IsPowerTwo
    {
        /*Approach
         * if a number is power of 2
         * only one of its bit would be one
         * keep dividing the number and keep check
         * on the number of 1s you see
         * if within the division loop you see more
         * than 1 1 return false. If when loop ends
         * check if you've seen any 1, if yes check
         * if n is one or zero and return appropiately
         */

        public bool IsPowerOfTwo(int n)
        {
            var list = new List<int>();
            while (n != 0 && n != 1)
            {
                var mod = n % 2;
                list.Add(mod);
                n /= 2;
            }
            list.Add(n);

            return list.Count(x => x == 1) == 1;
        }

        //25 Mins
        public bool IsPowerOfTwoOptimal(int n)
        {
            bool seen = false;
            while (n != 0 && n != 1)
            {
                var mod = n % 2;

                if (mod == 1 && !seen)
                    seen = true;
                else if (mod == 1 && seen)
                    return false;

                n /= 2;
            }

            if (seen)
                return n == 0;
            else
                return n == 1;
        }
    }
}
