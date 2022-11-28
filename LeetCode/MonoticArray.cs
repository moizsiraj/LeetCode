using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MonoticArray
    {
        /*Approach
         * check for increasing in a loop
         * check or decreasing in a loop
         * return their OR
         */
        public static bool IsMonotonic(int[] array)
        {
            var inceasing = true;
            var decreasing = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    continue;
                else 
                {
                    decreasing = false;
                    break;  
                }
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                    continue;
                else
                {
                    inceasing = false;
                    break;
                }
            }

            // Write your code here.
            return inceasing || decreasing;
        }
    }
}
