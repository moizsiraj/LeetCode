using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SubsetsTwo
    {
        public IList<IList<int>> SubsetsWithoutDup(int[] nums)
        {
            var sorted = nums.OrderBy(x => x).ToArray();
            var listOfList = new List<IList<int>>();
            PopulateList(sorted, 0, new List<int>(), listOfList);
            return listOfList;
        }

        private void PopulateList(int[] nums, int index, List<int> list, List<IList<int>> listOfList)
        {
            listOfList.Add(new List<int>(list));

            for (int i = index; i < nums.Length; i++)
            {
                if (i != index && nums[i] == nums[i - 1]) continue;

                list.Add(nums[i]);
                PopulateList(nums, i + 1, list, listOfList);
                list.Remove(nums[i]);
            }
        }
    }
}
