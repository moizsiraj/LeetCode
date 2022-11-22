using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PermutationTwo
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var frequencies = new Dictionary<int, int>();
            var permutation = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (frequencies.ContainsKey(nums[i]))
                    frequencies[nums[i]]++;
                else
                    frequencies.Add(nums[i], 1);
            }
            FillPermutation(frequencies, permutation, nums, new List<int>());

            return permutation;
        }

        private void FillPermutation(Dictionary<int, int> frequencies, List<IList<int>> permutation, int[] nums, List<int> list)
        {
            if (frequencies.Values.All(kv => kv == 0))
            {
                permutation.Add(new List<int>(list));
                return;
            }
            var map = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (frequencies[nums[i]] != 0 && !map.Contains(nums[i]))
                {
                    map.Add(nums[i]);
                    list.Add(nums[i]);
                    frequencies[nums[i]]--;
                    FillPermutation(frequencies, permutation, nums, list);
                    frequencies[nums[i]]++;
                    list.Remove(nums[i]);
                }
            }
        }

        private void PopulateSwap(int[] nums, int index, List<IList<int>> listOfList)
        {
            if (index == nums.Length)
            {
                listOfList.Add(new List<int>(nums));
                return;
            }

            for (int i = index; i < nums.Length; i++)
            {
                Swap(i, index);
                PopulateSwap(nums, i + 1, listOfList);
                Swap(i, index);
            }

            void Swap(int i, int j)
            {
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
    }
}
