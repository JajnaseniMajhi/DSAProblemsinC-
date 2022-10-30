using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public class CheckBSTOneChild
    {
        public string Solve(List<int> A)
        {
            if(A.Count==0)
            {
                return "NO";
            }
            int leftMax = int.MinValue;
            int rightMin = int.MaxValue;

            TreeNode root = null, node = null;
            for (int i = 0; i < A.Count; i++)
            {
                if (root == null)
                {
                    root = new TreeNode(A[i],null,null);
                    node = root;
                }
                else if (A[i] <= node.val && A[i] > leftMax)
                {
                    //left child
                    node.left = new TreeNode(A[i],null,null);
                    leftMax = node.val;
                    node = node.left;
                }
                else if (A[i] > node.val && A[i] < rightMin)
                {
                    //right child
                    node.right = new TreeNode(A[i],null,null);
                    rightMin = node.val;
                    node = node.right;
                }
                else
                {
                    return "NO";
                }
            }
            return "YES";
        }
    }
}
