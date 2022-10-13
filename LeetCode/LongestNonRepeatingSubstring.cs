using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LongestNonRepeatingSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            var set = new Dictionary<char, int>();
            var left = 0;
            var right = 0;
            var len = 0;
            var n = s.Length;

            while (right < n)
            {
                if (set.TryGetValue(s.ElementAt<char>(right), out int valIndex))
                {
                    left = Math.Max(valIndex + 1, left);
                    set[s.ElementAt<char>(right)] = right;
                }
                else
                {
                    set.Add(s.ElementAt<char>(right), right);
                }
                len = Math.Max(len, right - left + 1);
                right++;
            }
            return len;
        }

        public int LengthOfLongestSubstring2N(string s)
        {
            var set = new HashSet<char>();
            var left = 0;
            var right = 0;
            var max = 0;
            var temp = 0;
            var length = s.Length;

            while (left < length && right < length)
            {
                if (set.Contains(s.ElementAt<char>(right)))
                {
                    set.Remove(s.ElementAt(left));
                    left++;
                    temp--;
                }
                else
                {
                    set.Add(s.ElementAt<char>(right));
                    temp++;
                    right++;

                    if (temp > max)
                        max = temp;
                }
            }
            return max;
        }

        public int LengthOfLongestSubstringNaive(string s)
        {
            var set = new HashSet<char>();
            var max = int.MinValue;
            for (int i = 0; i < s.Length; i++)
            {
                set.Clear();
                var temp = 0;
                for (int j = i; j < s.Length; j++)
                {
                    if (set.Contains(s.ElementAt<char>(j)))
                        break;
                    set.Add(s.ElementAt<char>(j));
                    temp++;
                    if (temp > max)
                        max = temp;
                }
            }
            return max;
        }
    }
}
