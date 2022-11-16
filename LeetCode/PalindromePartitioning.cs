using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PalindromePartitioning
    {
        public IList<IList<string>> Partition(string s)
        {
            var listOfList = new List<IList<string>>();
            PopulateListOfList(s, listOfList, new List<string>(), 0);
            return listOfList;
        }

        private void PopulateListOfList(string s, List<IList<string>> listOfList, List<string> list, int index)
        {
            //Add list to result when partition get to the end of the array
            if (index == s.Length)
            {
                listOfList.Add(new List<string>(list));
                return;
            }

            //loop through all the indexes starting from index to n
            for (int i = index; i < s.Length; i++)
            {
                //if index to i substring is a palindrome
                if (StringIsPalindrome(s, index, i)) 
                {
                    var lenght = i + 1 - index;
                    var substring = s.Substring(index, lenght);
                    //add substring to the list
                    list.Add(substring);
                    //call function for the next index
                    PopulateListOfList(s, listOfList, list, i + 1);
                    //remove this added substring from the list to
                    //maintain the length of the string, if we dont
                    //remove this the lenght will become invalid
                    //and partitioning too
                    list.RemoveAt(list.Count - 1);
                }
            }
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
