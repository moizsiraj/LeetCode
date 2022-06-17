using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
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

    internal class MergeSortedList
    {
        private ListNode list1;
        private ListNode list2;

        public MergeSortedList(ListNode list1, ListNode list2)
        {
            this.list1 = list1;
            this.list2 = list2;
        }
        //43 mins
        public ListNode Solve() 
        {
            if (list1 == null) return list2;
            if(list2 == null ) return list1;
            ListNode head = new ListNode() { val = SetInitialValue()};
            ListNode current = head;
            while (list1 != null && list2 != null) 
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                    current = current.next;
                }
                else 
                {
                    current.next = list2;
                    list2 = list2.next;
                    current = current.next;
                }
            }

            while (list1 != null) 
            {
                current.next = list1;
                list1 = list1.next;
                current = current.next;
            } 
            while (list2 != null)
            {
                current.next = list2;
                list2 = list2.next;
                current = current.next;
            }
            return head;
            int SetInitialValue()
            {
                if (list1.val <= list2.val)
                {
                    var temp = list1.val;
                    list1 = list1.next;
                    return temp;
                }
                else
                {
                    var temp = list2.val;
                    list2 = list2.next;
                    return temp;
                }
            }
        }
    }
}
