using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MoveToEnd
    {
        /*Approach
         * use two pointers, move left faster than rigth, keep
         * plaing the desired number at the right until left right cross
         */
        public static List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            var left = 0;
            var right = array.Count - 1;
            while (left < right && left < array.Count) 
            {
                if (array[left] == toMove) 
                {
                    while (array[right] == toMove && left < right) 
                    {
                        right--;
                    }
                    if(left == right)
                        return array;
                    array[left] = array[right];
                    array[right] = toMove;
                }
                left++;
            }
            // Write your code here.
            return array;
        }
    }
}
