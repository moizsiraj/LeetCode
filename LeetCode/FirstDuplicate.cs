using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FirstDuplicate
    {
        /*Approach
         * keep adding to hashset
         * return number that map already contains
         * */
        public int FirstDuplicateValue(int[] array)
        {
            var map = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (map.Contains(array[i]))
                    return array[i];
                map.Add(array[i]);
            }
            return -1;
        }
    }
}
