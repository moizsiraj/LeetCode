using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseArray
    {
        public void ReverseRecursionBacktrack(int[] array, int left, int right) 
        {
            //left will go till length, right will retract till 0
            if (right < 0)
                return;
            //save value in this stack
            int val = array[left];
            //call funtion for next index
            ReverseRecursionBacktrack(array, left + 1, right - 1);
            //place the value saved in stack 
            array[right] = val;
        }

        public void ReverseRecursionOptimal2Params(int[] array, int left, int right)
        {
            //when left right intersect return
            if (left >= right)
                return;
            //swap
            var temp = array[right];
            array[right] = array[left];
            array[left] = temp;
            //call for next index
            ReverseRecursionOptimal2Params(array, left + 1, right - 1);
        }

        public void ReverseRecursionOptimal1Params(int[] array, int left)
        {
            //same logic as above with rigth value calculation
            var right = array.Length - left - 1;
            if (left >= right)
                return;
            var temp = array[right];
            array[right] = array[left];
            array[left] = temp;
            ReverseRecursionOptimal2Params(array, left + 1, right - 1);
        }
    }
}
