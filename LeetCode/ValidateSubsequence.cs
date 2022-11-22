using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ValidateSubsequence
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            var subIndex = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] == sequence[subIndex])
                    subIndex++;
            }
            return subIndex == sequence.Count;
        }
    }
}
