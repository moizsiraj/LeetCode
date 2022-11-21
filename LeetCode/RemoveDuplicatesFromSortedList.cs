using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RemoveDuplicatesFromSortedList
    {
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

        public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
        {
            if (linkedList.next == null)
                return linkedList;

            var current = linkedList;
            var next = linkedList.next;

            while (next != null)
            {
                if (current.value == next.value)
                {
                    current.next = next.next;
                    next = current.next;
                }
                else
                {
                    current = current.next;
                    next = next.next;

                }
            }

            return linkedList;
        }
    }
}
