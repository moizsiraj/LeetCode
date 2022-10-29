using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace LeetCode
{
    internal class PopulateNextRightPointer
    {
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
        
        /* Approach
         * use BFS to get the levels of the tree
         * set next for each node in each level
         */

        //1 hour+ 
        public Node Connect(Node root)
        {
            if (root is null) return root;

            var queue = new Queue<Node>();
            var list = new List<List<Node>>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var level = queue.Count;
                var levelList = new List<Node>();
                for (int i = 0; i < level; i++)
                {
                    var node = queue.Dequeue();
                    levelList.Add(node);
                    if (node.left is not null)
                        queue.Enqueue(node.left);
                    if (node.right is not null)
                        queue.Enqueue(node.right);
                }
                list.Add(levelList);
            }

            list.ForEach(ProcessList);
            return root;
        }

        private void ProcessList(List<Node> ll)
        {
            for (int i = 0; i < ll.Count - 1; i++)
            {
                ll.ElementAt(i).next = ll.ElementAt(i + 1);
            }
        }
    }
}
