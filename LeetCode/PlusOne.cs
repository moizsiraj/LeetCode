using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PlusOne
    {
        /* My Approach
         * For 0 to 8 just add 1 to last index
         * if last index is 9 run a while loop in revese
         * and until the value at index is 9 keep placing 0
         * when the loop ends, if value of index is -1 return new
         * array with 1 at the start index, else add one to start index
         */

        private int[] digits;

        public PlusOne(int[] digits)
        {
            this.digits = digits;
        }

        //27 Mins
        public int[] Solve()
        {
            double number = 0;
            if (digits[^1] < 9)
            {
                digits[^1]++;
                return digits;
            }
            else
            {
                int[] array = null;
                var index = digits.Length - 1;
                while (index >= 0 && digits[index] == 9) 
                {
                    digits[index] = 0;
                    index--;
                }
                if (index == -1)
                {
                    array = new int[digits.Length + 1];
                    Array.Copy(digits, 0, array, 1, digits.Length);
                    array[0] = 1;
                }
                else 
                {
                    digits[index]++;
                }
                return array is not null ? array : digits;
            }
        }
    }
}
