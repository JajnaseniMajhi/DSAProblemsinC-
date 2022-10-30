using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public  class LargestBST
    {
        public class NodeValue
        {
            public int maxNode, minNode, maxSize;

           public NodeValue(int minNode, int maxNode, int maxSize)
            {
                this.maxNode = maxNode;
                this.minNode = minNode;
                this.maxSize = maxSize;
            }
        }
        public int solve(TreeNode A)
        {
            var result = LargestBSTValue(A);
            return result.maxSize;

        }

        public NodeValue LargestBSTValue(TreeNode root)
        {
            if(root==null)
            {
                return new NodeValue(int.MaxValue, int.MinValue, 0);
            }

            NodeValue left = LargestBSTValue(root.left);
            NodeValue right = LargestBSTValue(root.right);

            //Check isBST of current node
            if(left.maxNode < root.val && right.minNode >root.val)
            {
                return new NodeValue(Math.Min(root.val, left.minNode), Math.Max(root.val, right.maxNode), left.maxSize + right.maxSize + 1);
            }
            return new NodeValue(int.MinValue, int.MaxValue, Math.Max(left.maxSize, right.maxSize));
        }
    }
}
