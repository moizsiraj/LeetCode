using LeetCode;
using System.Collections;
using System.Collections.Generic;
using static LeetCode.MergeBinaryTrees;
using static LeetCode.PopulateNextRightPointer;

public class Solution
{
    static void Main()
    {
        //int[][] a = new int[8][];
        //a[0] = new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 };
        //a[1] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 };
        //a[2] = new int[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 };
        //a[3] = new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 };
        //a[4] = new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 };
        //a[5] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 };
        //a[6] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 };
        //a[7] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 };
        //var sol = new MaxAreaOfIsland().maxAreaOfIsland(a);
        //Console.WriteLine(sol);

        var n1 = new Node(1);
        n1.left = new Node(2);
        n1.right = new Node(3);
        n1.left.left = new Node(4);
        n1.left.right = new Node(5);
        n1.right.left = new Node(6);
        n1.right.right = new Node(7);
        var sol = new PopulateNextRightPointer().Connect(n1);
        Console.WriteLine(sol);
    }
}
