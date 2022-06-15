using System.Collections;
using System.Collections.Generic;

public class Solution
{
    public bool IsPalindrome(int x)
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

    public int RomanToInt(string s)
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
                ones = ones + 1;
            }
            else if (currentChar == 'V' && prevChar == 'I')
            {
                ones = ones + 4;
                s = s[..^1];
            }
            else
            {
                ones = ones + 5;
            }
            if (s.Length >= 1)
                s = s[..^1];
            if (s.Length > 0)
            {
                currentChar = s.ElementAt<char>(s.Length - 1);
                prevChar = s.Length >= 2 ? s.ElementAt<char>(s.Length - 2) : 'O';
            }
        }
        while (
        currentChar != 'C' &&
        currentChar != 'D' &&
        currentChar != 'M' &&
        s.Length != 0
      )
        {
            if (currentChar == 'X' && prevChar == 'I')
            {
                ones = ones + 9;
                s = s[..^1];
            }
            else if (currentChar == 'X')
            {
                tens = tens + 10;
            }
            else if (currentChar == 'L' && prevChar == 'X')
            {
                tens = tens + 40;
                s = s[..^1];
            }
            else
            {
                tens = tens + 50;
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
                tens = tens + 90;
                s = s[..^1];
            }
            else if (currentChar == 'C')
            {
                hundreds = hundreds + 100;
            }
            else if (currentChar == 'D' && prevChar == 'C')
            {
                hundreds = hundreds + 400;
                s = s[..^1];
            }
            else
            {
                hundreds = hundreds + 500;
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
                hundreds = hundreds + 900;
                s = s[..^1];
            }
            else
            {
                thousands = thousands + 1000;
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

    static void Main()
    {
        var sol = new Solution();
        Console.WriteLine(sol.RomanToInt("MMMCMXCIX"));
    }
}
