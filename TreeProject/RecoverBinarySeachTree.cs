using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public  class RecoverBinarySeachTree
    {
        TreeNode prev = null;
        TreeNode first = null;
        TreeNode second = null;
        public List<int> RecoverBinaryTree(TreeNode treeNode)
        {
            if(treeNode == null)

            return null;

           TraverseInOrder(treeNode);

            return new List<int>() { second.val, first.val };
        }

        public void TraverseInOrder(TreeNode node)
        {
            if(node==null)
            {
                return;
            }
            TraverseInOrder(node.left);
            if(prev!=null && node!=null && prev.val>node.val)
            {
                if(first==null)
                {
                    first=prev;
                    second = node;
                }
                else
                {
                    second = prev;
                }
            }

            prev = node;
            TraverseInOrder(node.right);
        }

        
    }
}
