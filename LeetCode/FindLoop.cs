using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindLoopLinkedList
    {
		/*Approach
		 * All nodes are unique such that they have unique 
		 * memory address. Keep pushing all nodes into a hashmap
		 * the node that is already there in the hashmap is the
		 * loop node
		 */

		public static LinkedList FindLoop(LinkedList head)
		{
			var temp = head;
			var hashset = new HashSet<LinkedList>();
			while (!hashset.Contains(temp)) 
			{
				hashset.Add(temp);
				temp = temp.next;
			}
			// Write your code here.
			return temp;
		}

		public class LinkedList
		{
			public int value;
			public LinkedList next = null;

			public LinkedList(int value)
			{
				this.value = value;
			}
		}
	}
}
