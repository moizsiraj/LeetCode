using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PermutationOne
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var listOfList = new List<IList<int>>();
            var taken = new Dictionary<int, bool>();
            for (int i = 0; i < nums.Length; i++) 
            {
                taken.Add(nums[i], false);
            }
            PopulateList(nums, 0, listOfList, new List<int>(), taken);
            return listOfList;
        }

        private void PopulateList(int[] nums, int index, List<IList<int>> listOfList, List<int> list, Dictionary<int, bool> taken)
        {
            if (taken.All(kv => kv.Value == true))
            {
                listOfList.Add(new List<int>(list));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!taken[nums[i]]) 
                {
                    list.Add(nums[i]);
                    taken[nums[i]] = true;
                    PopulateList(nums, index + 1, listOfList, list, taken);
                    list.Remove(nums[i]);
                    taken[nums[i]] = false;
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
