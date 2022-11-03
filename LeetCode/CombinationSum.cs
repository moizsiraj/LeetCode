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
            //input [1,2,3], 3

            if (index >= candidates.Length)
            {
                if (sum == target)
                    listOfList.Add(new List<int>(list));
                return;
            }
            
            //Adds a number to the sequence
            list.Add(candidates[index]);
            //Adds the number to the sum
            sum += candidates[index];
            //until target is reached we keep adding the same number to the sequence because multiple instances of a candidate are allowed
            //this will go till [1,1,1,] and will print because this is = 3
            //from [1,1,1] and line 39 is executed, last 1 will be removed and 2 will be added making it [1,1,2] it will return as not =
            if (sum <= target)
                PopulateList(candidates, index, listOfList, list, sum, target);
            //logic for removing the value and calling for the next value
            list.Remove(candidates[index]);
            sum -= candidates[index];
            PopulateList(candidates, index + 1, listOfList, list, sum, target);
        }
    }
}
