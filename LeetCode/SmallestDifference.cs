using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SmallestDifferences
    {
        /*Sort both arrays, find difference between
         * same index elements using pointers. keep
         * a check on minimum through the loop.
         */
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);
            var min = int.MaxValue;
            var array = new int[2];
            var pOne = 0;
            var pTwo = 0;

            while (pOne < arrayOne.Length && pTwo < arrayTwo.Length) 
            {
                var current = Math.Abs(arrayTwo[pTwo] - arrayOne[pOne]);
                if (current == 0)
                {

                    array[0] = arrayOne[pOne];
                    array[1] = arrayTwo[pTwo];
                    return array;
                }
                else
                {
                    if (current < min)
                    { 
                        min = current;
                        array[0] = arrayOne[pOne];
                        array[1] = arrayTwo[pTwo];
                    }

                    if (arrayTwo[pTwo] > arrayOne[pOne])
                        pOne++;
                    else
                        pTwo++;
                }
            }
            
            return array;
        }
    }
}
