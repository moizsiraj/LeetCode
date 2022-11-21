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

        public class LinkedList
        {
            public int value;
            public LinkedList next;

            public LinkedList(int value)
            {
                this.value = value;
                this.next = null;
            }
        }

        /*Approach
         * Merge list without making any changes to the list.
         * Set the head of the list to return by chosing the lower
         * value head of the two lists. after that run two pointers comparing
         * the values of each node and placing them in the list, while moving
         * these two pointers ahead. when one of the pointer gets null. set the
         * other node to the next of the current node
         */
        public static LinkedList mergeLinkedLists(LinkedList headOne, LinkedList headTwo)
        {
            var head = headOne.value <= headTwo.value ? headOne : headTwo;
            var current = head;

            if (headOne.value <= headTwo.value)
            {
                headOne = headOne.next;
            }
            else 
            {
                headTwo = headTwo.next;
            }

            while (headOne != null && headTwo != null) 
            {
                if (headOne.value <= headTwo.value)
                {
                    current.next = headOne;
                    headOne = headOne.next;
                    current = current.next;
                }
                else 
                {
                    current.next = headTwo;
                    headTwo = headTwo.next;
                    current = current.next;
                }
            }

            if (headOne == null) 
            {
                current.next = headTwo;
            }

            if (headTwo == null) 
            {
                current.next = headOne;
            }
            // Write your code here.
            return head;
        }
    }
}
