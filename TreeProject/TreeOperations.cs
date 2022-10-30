using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public  class TreeOperations
    {
        public TreeNode CreateTree()
        {
            TreeNode root = new TreeNode( 1, null, null);
            root.left = new TreeNode(2, new TreeNode(4, null, null), new TreeNode(5, null, null));
            root.right = new TreeNode(3, new TreeNode(6, null, null), new TreeNode(7, null, null));

            return root;
        }

        public void PrintPreOrder(TreeNode root)
        {
            if(root==null)
            {
                return;
            }

            Console.WriteLine(root.val);
            PrintPreOrder(root.left);
            PrintPreOrder(root.right);
        }

        public void InOrder(TreeNode root)
        {
            if(root==null)
            {
                return ;
            }

            InOrder(root.left);
            Console.WriteLine(root.val);
            InOrder(root.right);
        }

        public bool FindElement(TreeNode  root, int k)
        {
            if (root == null)
                return false;
            if (root.val == k)
                return true;

            if(FindElement(root.left, k))
            {
                return true;
            }
            if(FindElement(root.right, k))
            {
                return true;
            }

            return false;
        }

        public TreeNode CreateTree(List<int> inOrder, List<int> postOrder)
        {

            return null;
        }

        public void FormTree(List<int> leftTree, List<int> rightTree, int postIndex)
        {

        }
    }
}
