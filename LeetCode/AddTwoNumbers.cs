using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AddTwoNumbers
    {
        public class LinkedListX
        {
            public int value;
            public LinkedListX next;

            public LinkedListX(int value)
            {
                this.value = value;
                this.next = null;
            }
        }

        /*Approach
         * take a carry to keep cary value on each sum
         * take a stack to store all the result numbers
         * until one of the linkedlist is empty get the
         * val to put in stack by taking mod by 10 and 
         * find carry by dividing by 10. Add the remaining
         * list items with using same val/carry approach
         * at the push the carry to the stack. Write the
         * stack as a linkedlist by popping and setting
         * nexts
         */

        public LinkedListX SumOfLinkedLists(LinkedListX linkedListOne, LinkedListX linkedListTwo)
        {
            var carry = 0;
            var stack = new Stack<LinkedListX>();
            int val;
            int temp;
            while (linkedListOne != null && linkedListTwo != null)
            {
                temp = linkedListOne.value + linkedListTwo.value + carry;
                val = temp % 10;
                carry = temp / 10;
                stack.Push(new LinkedListX(val));
                linkedListTwo = linkedListTwo.next;
                linkedListOne = linkedListOne.next;
            }

            if (linkedListOne == null) 
            {
                while (linkedListTwo != null) 
                {
                    temp = linkedListTwo.value + carry;
                    val = temp % 10;
                    carry = temp / 10;
                    stack.Push(new LinkedListX(val));
                    linkedListTwo = linkedListTwo.next;
                }
            }

            if (linkedListTwo == null)
            {
                while (linkedListOne != null)
                {
                    temp = linkedListOne.value + carry;
                    val = temp % 10;
                    carry = temp / 10;
                    stack.Push(new LinkedListX(val));
                    linkedListOne = linkedListOne.next;
                }
            }

            if (carry != 0)
                stack.Push(new LinkedListX(carry));

            var head = stack.Pop();

            while (stack.Count != 0) 
            {
                var node = stack.Pop();
                node.next = head;
                head = node;
            }

            return head;
        }
    }
}
