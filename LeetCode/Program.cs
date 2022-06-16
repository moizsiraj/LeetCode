using LeetCode;
using System.Collections;
using System.Collections.Generic;

public class Solution
{
    static void Main()
    {
        //var romanToInt = new RomanToInt();
        var lcp = new LongestCommonPrefix(new string[]{ "flower", "flow", "flight", "x" });
        Console.WriteLine(lcp.Solve());
    }
}
