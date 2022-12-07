using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ProductOfArray
    {
        /*Approach
         * Create two array one for the product of elements to the
         * left of each element, one for right elements. Index wise multiply
         * both arrays
         */
        public int[] ArrayOfProducts(int[] array)
        {
            var left = new int[array.Length];
            var right = new int[array.Length];
            var result = new int[array.Length];
           
            var lProduct = 1;
            var rProduct = 1;

            for (int lIdx = 0, rIdx = array.Length - 1; lIdx < array.Length; lIdx++, rIdx--)
            {
                //left product for first element will be 1
                left[lIdx] = lProduct;
                lProduct *= array[lIdx];

                //right product for last element will be 1
                right[rIdx] = rProduct;
                rProduct *= array[rIdx];
            }

            //multiply
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = left[i] * right[i];
            }

            return result;
        }
    }
}
