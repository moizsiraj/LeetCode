using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LongestCommonPrefix
    {
        private string[] _Strings;

        public LongestCommonPrefix(string[] strings)
        {
            _Strings = strings;
        }
        //57 mins
        public string Solve()
        {
            int currentCharIndex = 0;
            string prefix = string.Empty;
            if (_Strings[0].Length == 0)
                return prefix;
            while (true)
            {
                if(_Strings[0].Length <= currentCharIndex)
                    return prefix;
                char currentChar = _Strings[0].ElementAt<char>(currentCharIndex);
                for (int i = 0; i < _Strings.Length; i++)
                {
                    if (_Strings[i].Length <= currentCharIndex || _Strings[i].ElementAt<char>(currentCharIndex) != currentChar)
                    {
                        return prefix;
                    }
                }
                prefix = prefix + currentChar;
                currentCharIndex++;
            }
        }
    }
}
