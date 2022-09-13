using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LenghtOfLastWord
    {
        private string s;

        //can be done using another algo in O(n)
        //currently O(m*n)
        public LenghtOfLastWord(string s)
        {
            this.s = s;
        }

        //26 Mins
        public int Solve()
        {
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                while(i > 0 && s.ElementAt<char>(i) == ' ') 
                    i--;
                while (i >= 0 && char.IsLetter(s.ElementAt<char>(i)))
                {
                    count++;
                    i--;
                }
                break;
            }
            return count;
        }
    }
}
