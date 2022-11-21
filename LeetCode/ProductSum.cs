using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ProductSumRecursive
    {
        public static int ProductSum(List<object> array)
        {
            return Solve(array, 1);
        }

        private static int Solve(IList<object> array, int depth)
        {
            var sum = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] is IList<object> list)
                {
                    sum += (depth * (Solve(list, depth + 1)));
                }
                else
                {
                    sum += (depth * (int)array[i]);
                }
            }
            return sum;
        }

        public static List<List<int>> GetPermutations(List<int> array)
        {
            if(array.Count == 0)
                return new List<List<int>>();

            var listOfList = new List<List<int>>();
            var frequencyTable = new HashSet<int>();
            GetPermutations(listOfList, frequencyTable, array, new List<int>(), 0);
            return listOfList;
        }

        private static void GetPermutations(List<List<int>> listOfList, HashSet<int> frequencyTable, List<int> array, List<int> list, int index)
        {
            if (frequencyTable.Count == array.Count)
            {
                listOfList.Add(new List<int>(list));
                return;
            }

            for (int i = 0; i < array.Count; i++)
            {
                if (!frequencyTable.Contains(array[i]))
                {
                    list.Add(array[i]);
                    frequencyTable.Add(array[i]);
                    GetPermutations(listOfList, frequencyTable, array, list, index + 1);
                    list.Remove(array[i]);
                    frequencyTable.Remove(array[i]);
                }
            }
        }

        public static List<List<int>> Powerset(List<int> array)
        {
            var listOfLists = new List<List<int>>();
            GetPowerSet(listOfLists, array, new List<int>(), 0);
            return listOfLists;
        }

        private static void GetPowerSet(List<List<int>> listOfLists, List<int> array, List<int> list, int index)
        {
            if (index == array.Count) 
            {
                listOfLists.Add(new List<int>(list));
                return;
            }

            list.Add(array[index]);
            GetPowerSet(listOfLists, array, list, index + 1);
            list.Remove(array[index]);
            GetPowerSet(listOfLists, array, list, index + 1);
        }
    }
}
