using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RotateList
    {
        //Not Solved
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
                return null;
            if (head.next == null)
                return head;

            var length = 0;

            var temp = head;

            while (temp != null)
            {
                length++;
                temp = temp.next;
            }

            k = k % length;

            var current = head;
            var end = head.next;

            for (int i = 0; i < k; i++)
            {
                end = end.next;
            }

            var endPointer = end;
            while (end != null)
            {
                endPointer = end;
                current = current.next;
                end = end.next;
            }

            if (endPointer == null) 
            {
                head.next.next = head;
                var newHeadx = head.next;
                head.next = null;
                head = newHeadx;
            }

            var newHead = current.next;
            current.next = null;
            endPointer.next = head;
            head = newHead;

            return head;
        }
    }
}
