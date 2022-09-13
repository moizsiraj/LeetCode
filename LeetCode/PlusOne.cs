using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PlusOne
    {
        private int[] digits;

        //not complete
        public PlusOne(int[] digits)
        {
            this.digits = digits;
        }

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
                for (int i = 0, j = digits.Length - 1; i < digits.Length; i++, j--)
                {
                    number += digits[j] * Math.Pow(10, i);
                }
                number++;
            }

            int length = 0;
            double temp = number;
            
            while (temp >= 10)
            { 
                temp /= 10;
                length++;
            }
            length++;
            
            var array = new int[length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                double mod = number % 10;
                array[i] = (int)mod;
                number /= 10;
            }
            return array;
        }
    }
}
