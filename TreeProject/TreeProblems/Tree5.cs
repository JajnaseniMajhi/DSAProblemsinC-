using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject.TreeProblems
{
    public class Tree5
    {
        public TreeNode InvertTree(TreeNode A)
        {
            if (A == null)
            {
                return null;
            }

            TreeNode temp = A;

            var left=InvertTree(temp.left);
            var right=InvertTree(temp.right);
            temp.left=right;
            temp.right=left;
            return temp;
            
        }
    }
}
