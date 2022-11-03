using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CombineSumTwo
    {
        //Combination doesn't have to be a subsequence it can be unordered

        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            var listOfList = new List<IList<int>>();
            Array.Sort(candidates);
            PopulateListOfList(candidates, 0, 0, target, listOfList, new List<int>());
            return listOfList;
        }

        private void PopulateListOfList(int[] candidates, int index, int sum, int target, List<IList<int>> listOfList, List<int> list)
        {

            //Add combination when target is reached
            if (sum == target)
            {
                listOfList.Add(new List<int>(list));
                return;
            }

            for (int i = index; i < candidates.Length; i++)
            {
                //if i is not equal to current index(we want to include index), and it's value is seen before we skip this i
                if (i > index && candidates[i] == candidates[i - 1]) continue;

                //if value exceeds target no need to go ahead as list is sorted
                if (candidates[i] > target) break;

                //add the candidate i to the seq
                list.Add(candidates[i]);
                sum += candidates[i];
                //make call for the next i
                PopulateListOfList(candidates, i + 1, sum, target, listOfList, list);
                //remove the candidate i you added, to cater for the not pick choice
                list.Remove(candidates[i]);
                sum -= candidates[i];
            }
        }
    }
}
