using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Subsequences
    {
        public void PrintAllSubsequences(int[] array) 
        {
            PrintSequence(array, new List<int>(), 0);
        }

        private void PrintSequence(int[] array, List<int> seq, int index) 
        {
            if (index >= array.Length)
            {
                seq.ForEach(Console.Write);
                Console.WriteLine();
                return;
            }
            seq.Add(array[index]);
            PrintSequence(array, seq, index + 1);
            seq.Remove(array[index]);
            PrintSequence(array, seq, index + 1);
        }
    }
}
