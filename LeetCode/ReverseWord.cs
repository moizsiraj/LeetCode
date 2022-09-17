using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseWord
    {
        /*My Approach
         * start left right pointers from start of string
         * move right pointer to the nearest space
         * reverse the chars between left and right pointer
         * set left pointer and right pointer to right of the right pointer
         */

        public string ReverseWords(string s)
        {
            var wordStart = 0;
            var nextSpace = 0;
            var strArray = s.ToCharArray();

            while (nextSpace < s.Length)
            {
                while (nextSpace < s.Length && s.ElementAt(nextSpace) != ' ')
                    nextSpace++;

                Reverse(strArray, wordStart, nextSpace - 1);
                wordStart = nextSpace + 1;
                nextSpace = wordStart;
            }

            var result = string.Empty;

            for (int i = 0; i < strArray.Length; i++)
            {
               result += strArray[i];
            }

            return result;
        }

        private void Reverse(char[] strArray, int wordStart, int nextSpace)
        {
            var tempStart = wordStart;
            var tempSpace = nextSpace;
            while (tempStart < tempSpace) 
            {
                (strArray[tempSpace], strArray[tempStart]) = (strArray[tempStart], strArray[tempSpace]);
                tempStart++;
                tempSpace--;
            }
        }

        public string stringNaiveReverseWord(string s) 
        {
            var str = new StringBuilder();

            var strArray = s.Split(' ');

            for (int i = 0; i < strArray.Length; i++)
            {
                var tempStr = strArray[i];
                var lastIndex = tempStr.Length - 1;

                while (lastIndex >= 0)
                {
                    str.Append(tempStr.ElementAt(lastIndex));
                    lastIndex--;
                }
                str.Append(' ');
            }
            return str.ToString().Trim();
        }
    }
}
