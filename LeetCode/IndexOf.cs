using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IndexOf
    {
        /* My Approach
         * loop over the haystack
         * when a char is equal to start of the needle start another loop
         * set the exist flag to true and save the starting index
         * if char do not match anymore set exist to false and break that loop 
         * when the loop breaks or ends check if exist is true or flase
         * if true return the index
         * if false set index back to -1;
         */

        private string haystack;
        private string needle;

        public IndexOf(string haystack, string needle)
        {
            this.haystack = haystack;
            this.needle = needle;
        }

        //23 mins
        public int Solve()
        {
            int indexOf = -1;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack.ElementAt(i) == needle.ElementAt(0))
                {
                    bool exist = true;
                    indexOf = i;
                    for (int j = 1, k = i + 1; j < needle.Length; j++, k++)
                    {
                        if (k >= haystack.Length) return -1;
                        if (haystack.ElementAt(k) != needle.ElementAt(j))
                        {
                            exist = false;
                            break;
                        }
                    }
                    if (exist)
                    {
                        return indexOf;
                    }
                    else 
                    {
                        indexOf = -1;
                    }
                }
            }
            return indexOf;
        }
    }
}
