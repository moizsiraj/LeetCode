using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PermutationInString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            var s1Length = s1.Length;
            var s2Length = s2.Length;

            if (s2Length < s1Length) return false;

            var s1Dictionary = new Dictionary<char, int>();
            var s2Dictionary = new Dictionary<char, int>();

            for (int i = 0; i < s1Length; i++)
            {
                if (s1Dictionary.ContainsKey(s1.ElementAt(i)))
                {
                    s1Dictionary[s1.ElementAt(i)]++;
                }
                else
                {
                    s1Dictionary.Add(s1.ElementAt(i), 1);
                }
            }

            var left = 0;
            var right = s1.Length - 1;

            for (int i = left; i <= right; i++)
            {
                if (s2Dictionary.ContainsKey(s2.ElementAt(i)))
                {
                    s2Dictionary[s2.ElementAt(i)]++;
                }
                else
                {
                    s2Dictionary.Add(s2.ElementAt(i), 1);
                }
            }

            while (right < s2.Length)
            {
                var dictionariesEqual = AreDictionariesEqual(s1, s1Dictionary, s2Dictionary);
                if (dictionariesEqual) return true;

                if (s2Dictionary.ContainsKey(s2.ElementAt(left))) 
                {
                    if (s2Dictionary[s2.ElementAt(left)] == 1)
                        s2Dictionary.Remove(s2.ElementAt(left));
                    else
                        s2Dictionary[s2.ElementAt(left)]--;
                }
                left++;
                right++;

                if (right >= s2Length)
                    break;

                if (s2Dictionary.ContainsKey(s2.ElementAt(right)))
                {
                    s2Dictionary[s2.ElementAt(right)]++;
                }
                else
                {
                    s2Dictionary.Add(s2.ElementAt(right), 1);
                }
            }
            return false;
        }

        private bool AreDictionariesEqual(string s1, Dictionary<char, int> s1Dictionary, Dictionary<char, int> s2Dictionary)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (!s2Dictionary.ContainsKey(s1.ElementAt(i))) 
                    return false;
                else if(s2Dictionary[s1.ElementAt(i)] != s1Dictionary[s1.ElementAt(i)])
                    return false;
            }
            return true;
        }
    }
}
