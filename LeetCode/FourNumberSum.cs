using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FourNumberSums
    {
        public static List<int[]> FourNumberSum(int[] array, int targetSum)
        {
            var listOfList = new List<int[]>();
            PopulateList(array, listOfList, new List<int>(), 0, targetSum, 0);
            return new List<int[]>();
        }

        /*Brute Force
         * Find all combos that return the sum and are equal to array.length
         */
        private static void PopulateList(int[] array, List<int[]> listOfList, List<int> ints, int index, int targetSum, int currentSum)
        {
            if (index == array.Length) 
            {
                if(currentSum == targetSum && ints.Count == 4)
                    listOfList.Add(ints.ToArray());
            }
            ints.Add(array[index]);
            PopulateList(array, listOfList, ints, index + 1, targetSum, currentSum + array[index]);
            ints.RemoveAt(ints.Count - 1);
            PopulateList(array, listOfList, ints, index + 1, targetSum, currentSum);
        }

        /*Optimal Approach
         * 2 nested loops keeping track of two numbers
         * left and right pointers to keep track of other 
         * two numbers
         */
        public static List<int[]> FourNumberSumOptimal(int[] array, int targetSum)
        {
            array = array.OrderBy(x => x).ToArray();
            var listOfList = new List<int[]>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    var left = j + 1;
                    var right = array.Length - 1;

                    while (left < right) 
                    {
                        if (array[left] + array[right] + array[i] + array[j] > targetSum)
                            right--;
                        else if (array[left] + array[right] + array[i] + array[j] < targetSum)
                            left++;
                        else 
                        {
                            listOfList.Add(new int[] { array[i], array[j], array[left], array[right] });
                            left++;
                            right--;
                        }
                    }
                }
            }
            return listOfList;
        }

        /*Optimal Approach No Duplicates
         * 2 nested loops keeping track of two numbers
         * left and right pointers to keep track of other 
         * two numbers. after finding combnination, keep moving left
         * and right until you see different number than previous left
         * and right. Do same with i and j
         */
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            nums = nums.OrderBy(x => x).ToArray();
            var listOfList = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var left = j + 1;
                    var right = nums.Length - 1;

                    while (left < right)
                    {
                        if (nums[left] + nums[right] + nums[i] + nums[j] > target)
                            right--;
                        else if (nums[left] + nums[right] + nums[i] + nums[j] < target)
                            left++;
                        else
                        {
                            listOfList.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                            left++;
                            right--;

                            while (left - 1 >= 0 && left < nums.Length - 1 && nums[left] == nums[left - 1])
                                left++;
                            while (right < nums.Length - 2 && right >= 0 && nums[right] == nums[right + 1])
                                right--;
                        }
                    }
                    while (j < nums.Length - 2 && nums[j] == nums[j + 1])
                        j++;
                }
                while (i < nums.Length - 2 && nums[i] == nums[i + 1])
                    i++;
            }
            return listOfList;
        }
    }
}
