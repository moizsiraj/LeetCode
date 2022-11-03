using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CombinationSumOne
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target, bool once)
        {
            var listOfList = new List<IList<int>>();
            PopulateList(candidates, 0, listOfList, new List<int>(), 0, target);
            return listOfList;
        }

        private void PopulateList(int[] candidates, int index, List<IList<int>> listOfList, List<int> list, int sum, int target)
        {
            if (index >= candidates.Length)
            {
                if (sum == target)
                    listOfList.Add(new List<int>(list));
                return;
            }

            list.Add(candidates[index]);
            sum += candidates[index];
            if (sum <= target)
                PopulateList(candidates, index, listOfList, list, sum, target);
            list.Remove(candidates[index]);
            sum -= candidates[index];
            PopulateList(candidates, index + 1, listOfList, list, sum, target);
        }
    }
}
