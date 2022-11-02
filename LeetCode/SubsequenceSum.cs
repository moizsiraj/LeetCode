using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SubsequenceSum
    {
        public void PrintAllSubsequencesWithSumK(int[] array, int k, bool optimal)
        {
            if (optimal)
                Console.WriteLine(PrintNumerSequence(array, 0, 0, k));
            else
                PrintSequence(array, new List<int>(), new HashSet<string>(), 0, k);
        }

        private void PrintSequence(int[] array, List<int> seq, HashSet<string> result, int index, int k)
        {
            var sum = 0;
            var str = "";
            seq.ForEach(num => sum += num);
            if (sum == k)
            {
                seq.ForEach(num => str += num.ToString() + " ");
                if (!result.Contains(str))
                {
                    Console.WriteLine(str);
                    result.Add(str);
                }
            }

            if (index >= array.Length)
                return;

            seq.Add(array[index]);
            PrintSequence(array, seq, result, index + 1, k);
            seq.Remove(array[index]);
            PrintSequence(array, seq, result, index + 1, k);
        }

        private void PrintSequenceOptimal(int[] array, List<int> seq, int sum, int index, int k)
        {
            if (index >= array.Length)
            {
                if (sum == k)
                {
                    seq.ForEach(Console.Write);
                    Console.WriteLine();
                }
                return;
            }

            seq.Add(array[index]);
            sum += array[index];
            PrintSequenceOptimal(array, seq, sum, index + 1, k);
            seq.Remove(array[index]);
            sum -= array[index];
            PrintSequenceOptimal(array, seq, sum, index + 1, k);
        }

        private bool PrintSequenceOptimalPrintOne(int[] array, List<int> seq, int sum, int index, int k, bool printed)
        {
            if (printed) return true;

            if (index >= array.Length)
            {
                if (sum == k)
                {
                    seq.ForEach(Console.Write);
                    Console.WriteLine();
                    return true;
                }
                return false;
            }

            seq.Add(array[index]);
            sum += array[index];
            printed = PrintSequenceOptimalPrintOne(array, seq, sum, index + 1, k, printed);
            seq.Remove(array[index]);
            sum -= array[index];
            return PrintSequenceOptimalPrintOne(array, seq, sum, index + 1, k, printed);
        }

        private bool PrintSequenceOptimalPrintOne(int[] array, List<int> seq, int sum, int index, int k)
        {
            if (index >= array.Length)
            {
                if (sum == k)
                {
                    seq.ForEach(Console.Write);
                    Console.WriteLine();
                    return true;
                }
                return false;
            }

            seq.Add(array[index]);
            sum += array[index];
            if (PrintSequenceOptimalPrintOne(array, seq, sum, index + 1, k)) return true;
            seq.Remove(array[index]);
            sum -= array[index];
            if (PrintSequenceOptimalPrintOne(array, seq, sum, index + 1, k)) return true;
            return false;
        }

        private int PrintNumerSequence(int[] array, int sum, int index, int k)
        {
            if (index >= array.Length)
            {
                if (sum == k)
                {
                    return 1;
                }
                return 0;
            }

            sum += array[index];
            var take = PrintNumerSequence(array, sum, index + 1, k);
            sum -= array[index];
            var notTake = PrintNumerSequence(array, sum, index + 1, k);
            return take + notTake;
        }
    }
}
