using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PalindromePartitioningTwo
    {
        public int MinCut(string s)
        {
            return PopulateListOfList(s, new List<string>(), 0, int.MaxValue);
        }

        private int PopulateListOfList(string s, List<string> list, int index, int currentMin)
        {
            //when partition gets to end of the string check length with current minimum and return minimum
            if (index == s.Length)
            {
                return Math.Min(currentMin, list.Count - 1);
            }

            //loop thtough index till n and check for substrings
            for (int i = index; i < s.Length; i++)
            {
                //if substring from index till i is a palindrome 
                if (StringIsPalindrome(s, index, i))
                {
                    var lenght = i + 1 - index;
                    var substring = s.Substring(index, lenght);
                    //Add substring to the list
                    list.Add(substring);
                    //make call for the next index
                    currentMin = Math.Min(PopulateListOfList(s, list, i + 1, currentMin), currentMin);
                    //remove this added substring from the list to
                    //maintain the length of the string, if we dont
                    //remove this the lenght will become invalid
                    //and partitioning too
                    list.Remove(substring);
                }
            }
            return currentMin;
        }

        private bool StringIsPalindrome(string s, int left, int right)
        {
            while (left < right)
            {
                if (s.ElementAt(left) == s.ElementAt(right))
                {
                    left++;
                    right--;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
