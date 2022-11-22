using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TwoSum
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < array.Length; i++)
            {
                var key = array[i];
                var val = targetSum - key;
                
                if (dictionary.ContainsKey(val))
                {
                    return new int[] { dictionary[val], key };
                }
                dictionary[key] = val;
            }
            return new int[0];
        }
    }
}
