using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MergeBinaryTrees
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        /*Approach
         * traverse both the trees recursively
         * check for conditions and return the node
         * after setting the lefts and rigths recursively
         */

        //27 Mins
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            return MergeTrees(root1, root2);
        }

        private TreeNode Merge(TreeNode root1, TreeNode root2) 
        {
            if (root1 == null && root2 == null) return null;

            if(root1 == null) return root2;

            if (root2 == null) return root1;

            var node = new TreeNode(root1.val + root2.val);

            node.left = Merge(root1.left, root2.left);
            node.right = Merge(root1.right, root2.right);
            return node;
        }
    }
}
