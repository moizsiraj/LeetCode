using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Subset
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var listOfList = new List<IList<int>>();
            PopulateList(listOfList, new List<int>(), nums, 0);
            return listOfList;
        }

        private void PopulateList(IList<IList<int>> listOfList, List<int> list, int[] nums, int index) 
        {
            if (index > nums.Length)
            {
                listOfList.Add(new List<int>(list));
                return;
            }

            list.Add(nums[index]);
            PopulateList(listOfList , list, nums, index + 1);
            list.Remove(nums[index]);
            PopulateList(listOfList, list, nums, index + 1);
        }
    }
}
