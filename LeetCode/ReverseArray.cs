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
            if (right < 0)
                return;
            int val = array[left];
            ReverseRecursionBacktrack(array, left + 1, right - 1);
            array[right] = val;
        }

        public void ReverseRecursionOptimal2Params(int[] array, int left, int right)
        {
            if (left >= right)
                return;
            var temp = array[right];
            array[right] = array[left];
            array[left] = temp;
            ReverseRecursionOptimal2Params(array, left + 1, right - 1);
        }

        public void ReverseRecursionOptimal1Params(int[] array, int left)
        {
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
