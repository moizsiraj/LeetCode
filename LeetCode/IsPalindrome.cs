using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IsPalindrome
    {
        //1 hour
        public bool IsPalindromeInt(int x)
        {
            Stack<int> s = new Stack<int>();
            Stack<int> s2 = new Stack<int>();
            int count = 0;
            while (x / 10 != 0)
            {
                count++;
                s.Push(Math.Abs(x % 10));
                x /= 10;
            }
            s.Push(x);
            count++;
            if (s.Count == 1)
            {
                if (s.Pop() < 0)
                    return false;
                else
                    return true;
            }
            for (int i = 0; i < count / 2; i++)
            {
                s2.Push(s.Pop());
            }
            if (count % 2 != 0)
            {
                s.Pop();
            }
            while (s.Count != 0)
            {
                if (s.Pop() != s2.Pop())
                    return false;
            }
            return true;
        }
    }
}
