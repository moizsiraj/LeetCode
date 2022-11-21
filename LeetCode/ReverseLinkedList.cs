using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseLinkedList
    {

        /*Approach
         * Push all the nodes in a stack
         * remove the first top of stack and set as head and current;
         * keep popping until the stack is empty and keep
         * pointing the next of the current node to the popped node;
         */

        //24 Mins
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;
            if(head.next == null) return head;

            var stack = new Stack<ListNode>();

            while (head != null) 
            {
                stack.Push(head);
                head = head.next;
            }

            head = stack.Pop();
            var temp = head;
            while (stack.Count != 0) 
            {
                var popped = stack.Pop();
                popped.next = null;
                temp.next = popped; 
                temp = temp.next;
            }

            return head;
        }

        /*No Stack Approach
         * use three pointers and re arrange the next
         * pointers of the nodes. Start prev at null, current
         * at head and next at head.next. Move until next is null
         * set current.next to prev at the end
         */

        public ListNode ReverseListPointer(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            ListNode prev = null;
            var current = head;
            var next = head.next;

            while (next != null) 
            {
                current.next = prev;
                prev = current;
                current = next;
                next = current.next;
            }

            current.next = prev;

            return current;
        }
    }
}
