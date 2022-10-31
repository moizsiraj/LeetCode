using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MergeTwoSortedLists
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class MergeTwoSortedLists
    {
        /*Approach
         * Add a head node and traverse through
         * the lists placing the smaller of the
         * node in front of the current node
         */

        //24 Mins
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null) return null;
            if (list2 == null) return list1;
            if (list1 == null) return list2;

            ListNode result = new ListNode();
            var head = result;
            while (list1 != null && list2 != null) 
            {
                if (list1.val <= list2.val)
                {
                    result.next = list1;
                    result = list1;
                    list1 = list1.next;
                }
                else 
                {
                    result.next = list2;
                    result = list2;
                    list2 = list2.next;
                }
            }

            if (list1 == null && list2 == null)
            {
                return head.next;
            }
            else if (list1 == null && list2 != null)
            {
                result.next = list2;
            }
            else if (list2 == null && list1 != null) 
            {
                result.next = list1;
            }
            return head.next;
        }
    }
}
