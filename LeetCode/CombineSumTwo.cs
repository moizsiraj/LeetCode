using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CombineSumTwo
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            var listOfList = new List<IList<int>>();
            Array.Sort(candidates);
            PopulateListOfList(candidates, 0, 0, target, listOfList, new List<int>());
            return listOfList;
        }

        private void PopulateListOfList(int[] candidates, int index, int sum, int target, List<IList<int>> listOfList, List<int> list)
        {

            if (sum == target)
            {
                listOfList.Add(new List<int>(list));
                return;
            }

            for (int i = index; i < candidates.Length; i++)
            {
                if (i > index && candidates[i] == candidates[i - 1]) continue;

                if (candidates[i] > target) break;

                list.Add(candidates[i]);
                sum += candidates[i];
                PopulateListOfList(candidates, i + 1, sum, target, listOfList, list);
                list.Remove(candidates[i]);
                sum -= candidates[i];
            }
        }
    }
}
