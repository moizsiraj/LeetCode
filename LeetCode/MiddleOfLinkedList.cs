using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MiddleOfLinkedList
    {
        /*My Approach
         * Use two pointers middle and end
         * start at head and move middle once and end twice
         * untill end is null or end.next is null
         */

        //11 Mins
        public ListNode MiddleNode(ListNode head)
        {
            ListNode middle = head;
            ListNode end = head;

            while (end != null && end.next != null)
            {
                middle = middle.next;
                end = end.next.next;
            }
            return middle;
        }
    }
}
