using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public class BalancedBinaryTree
    {
       
        public bool IsBalanced(TreeNode A)
        {
            if (A == null)
                return true;

            return FindHeight(A) != -1;
            
        }

        public int FindHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftH = FindHeight(root.left);
            int rightH = FindHeight(root.right);
            int bf = Math.Abs(leftH - rightH);
            if (bf > 1 || leftH == -1 || rightH == -1) return -1;

            return Math.Max(leftH, rightH) + 1;

        }
    }
}
