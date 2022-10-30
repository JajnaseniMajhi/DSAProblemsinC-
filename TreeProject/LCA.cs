using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public class LCA
    {
        public int LCAINBST(TreeNode treeNode, int B, int C)
        {

            //Find Path B
            //Find Path C

            //Find the common Node
            if(treeNode==null)
            {
                return 0;
            }
            if (treeNode.val>B && treeNode.val>C)
            {
               return LCAINBST(treeNode.left, B,C);
            }

            if(treeNode.val<B && treeNode.val<C)
            {
                return LCAINBST(treeNode.right, B, C);
            }

            else
            {
                return treeNode.val;
            }

        }

        public int LCANormalBinaryTree(TreeNode treeNode, int B, int C)
        {
            //step-1
            //find the path of B
            //find the path of C
            //Step-2
            //FInd the commaon element in both list 
            //that will be the result
            return 0;
        }
        List<int> path = new List<int>();
        public bool FindPath(TreeNode treeNode, int value)
        {
            if(treeNode==null)
            {
                return false;
            }
            path.Add(value);

            if(treeNode.val==value)
            {
                return true;
            }

            if(FindPath(treeNode.left, value))
            {
                return true;
            }

            if(FindPath(treeNode.right,value))
            {
                return true;
            }

            path.Remove(treeNode.val);
            return false;

        }
    }
}
