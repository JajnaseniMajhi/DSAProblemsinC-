using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;

        public TreeNode(int val,TreeNode left, TreeNode right)
        {
            this.left = left;
            this.right = right;
            this.val = val;
        }
    }
}
