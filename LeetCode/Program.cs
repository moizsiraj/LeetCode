using LeetCode;
using System.Collections;
using System.Collections.Generic;

public class Solution
{
    static void Main()
    {
        int[][] a = new int[2][];
        a[0] = new int[] { 0, 0, 0 };
        a[1] = new int[] { 1, 0, 0 };

        var sol = new FloodFills().FloodFill(a,1,0,2 );
        Console.WriteLine(sol);
    }
}
