using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RomanToInt
    {
        //1 hour 45 mins
        public int RomanToIntSol(string s)
        {
            int ones = 0;
            int tens = 0;
            int hundreds = 0;
            int thousands = 0;

            char currentChar = s.ElementAt<char>(s.Length - 1);
            char prevChar = s.Length >= 2 ? s.ElementAt<char>(s.Length - 2) : 'O';
            
            while (
                    currentChar != 'X' &&
                    currentChar != 'L' &&
                    currentChar != 'C' &&
                    currentChar != 'D' &&
                    currentChar != 'M' &&
                    s.Length != 0
                  )
            {
                if (currentChar == 'I')
                {
                    ones++;
                }
                else if (currentChar == 'V' && prevChar == 'I')
                {
                    ones += 4;
                    s = s[..^1];
                }
                else
                {
                    ones += 5;
                }
                if (s.Length >= 1)
                    s = s[..^1];
                if (s.Length > 0)
                {
                    currentChar = s.ElementAt<char>(s.Length - 1);
                    prevChar = s.Length >= 2 ? s.ElementAt<char>(s.Length - 2) : 'O';
                }
            }

            while   ( 
                    currentChar != 'C' &&
                    currentChar != 'D' &&
                    currentChar != 'M' &&
                    s.Length != 0
                    )
            {
                if (currentChar == 'X' && prevChar == 'I')
                {
                    ones += 9;
                    s = s[..^1];
                }
                else if (currentChar == 'X')
                {
                    tens += 10;
                }
                else if (currentChar == 'L' && prevChar == 'X')
                {
                    tens += 40;
                    s = s[..^1];
                }
                else
                {
                    tens += 50;
                }
                if (s.Length >= 1)
                    s = s[..^1];
                if (s.Length > 0)
                {
                    currentChar = s.ElementAt<char>(s.Length - 1);
                    prevChar = s.Length >= 2 ? s.ElementAt<char>(s.Length - 2) : 'O';
                }
            }

            while (currentChar != 'M' && s.Length != 0)
            {
                if (currentChar == 'C' && prevChar == 'X')
                {
                    tens += 90;
                    s = s[..^1];
                }
                else if (currentChar == 'C')
                {
                    hundreds += 100;
                }
                else if (currentChar == 'D' && prevChar == 'C')
                {
                    hundreds += 400;
                    s = s[..^1];
                }
                else
                {
                    hundreds += 500;
                }
                if (s.Length >= 1)
                    s = s[..^1];
                if (s.Length > 0)
                {
                    currentChar = s.ElementAt<char>(s.Length - 1);
                    prevChar = s.Length >= 2 ? s.ElementAt<char>(s.Length - 2) : 'O';
                }
            }

            while (s.Length != 0)
            {
                if (currentChar == 'M' && prevChar == 'C')
                {
                    hundreds += 900;
                    s = s[..^1];
                }
                else
                {
                    thousands += 1000;
                }
                if (s.Length >= 1)
                    s = s[..^1];
                if (s.Length > 0)
                {
                    currentChar = s.ElementAt<char>(s.Length - 1);
                    prevChar = s.Length >= 2 ? s.ElementAt<char>(s.Length - 2) : 'O';
                }
            }

            return ones + tens + hundreds + thousands;
        }
    }
}
