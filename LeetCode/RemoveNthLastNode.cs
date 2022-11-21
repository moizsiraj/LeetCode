using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RemoveNthLastNode
    {
        /*My Approach
         * take two pointers one at head and other at the off set of n from head
         * in a loop until last.next is not equal to null increment the pointers
         * dereference the node that is to be deleted by left.next = left.next.next
         * Corner Case : Single node list, return null
         * Corner Case : nth from last == head, return head.next
         */

        /*Another Approach
         * Add a dummy node so that left pointer stops at the left of the node that
         * is to be deleted
         */


        //50 Mins
        public ListNode? RemoveNthFromEnd(ListNode head, int n)
        {
            var left = head;
            var last = head;

            //if linked list has single node
            if (head.next == null && n == 1)
                return null;

            for (int i = 0; i < n; i++)
            {
                last = last.next;
            }

            //if first node needs to be removed
            //i.e. nth from last == head
            if (last == null)
            {
                head = head.next!;
                return head;
            }


            while (last.next != null)
            {
                left = left.next;
                last = last.next;
            }

            left.next = left?.next?.next!;
            return head;
        }

        public ListNode? RemoveNthFromEndDummyNode(ListNode head, int n)
        {
            var dummy = new ListNode() { val = 0, next = head };

            var left = dummy;
            var last = head;

            //if linked list has single node
            if (head.next == null && n == 1)
                return null;

            for (int i = 0; i < n; i++)
            {
                last = last.next;
            }

            //if first node needs to be removed
            //i.e. nth from last == head
            if (last == null)
            {
                head = head.next!;
                return head;
            }


            while (last != null)
            {
                left = left.next;
                last = last.next;
            }

            left.next = left?.next?.next!;
            return dummy.next;
        }

        /*Approach
         * take 3 prointers all pointing to head
         * update the end pointer kuch that its distance from
         * head is k. Keep moving end and current until end traverses
         * the while list. While doing so maintain a prev pointer for
         * current pointer. if current is not head set the next of prev
         * node to the next of current node. if its head, update current values
         * with current.next and dereference current.next
         */

        public static void RemoveKthNodeFromEnd(LinkedList head, int k)
        {
            var prev = head;
            var current = head;
            var end = head;

            for (int i = 0; i < k; i++)
            {
                end = end?.Next;
            }

            while (end != null)
            {
                prev = current;
                current = current.Next;
                end = end.Next;
            }

            if (current != null && current != head)
            {
                prev.Next = current.Next;
            }
            else if (current != null && current == head)
            {
                current.Value = current.Next.Value;
                current.Next = current.Next.Next;
            }

        }

        public class LinkedList
        {
            public int Value;
            public LinkedList Next = null;

            public LinkedList(int value)
            {
                this.Value = value;
            }
        }
    }
}
