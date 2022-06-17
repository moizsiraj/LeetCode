using LeetCode;
using System.Collections;
using System.Collections.Generic;

public class Solution
{
    static void Main()
    {
        //var romanToInt = new RomanToInt();
        var msl = new MergeSortedList(list1: new ListNode(val: 1, next: new ListNode(val: 2, next: new ListNode(val: 4))), list2: new ListNode(val: 1, next: new ListNode(val: 3, next: new ListNode(val: 4))));
        Console.WriteLine(msl.Solve());
    }
}
