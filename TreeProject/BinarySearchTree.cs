using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public class BinarySearchTree
    {
        public int IsValidBST(TreeNode A)
        {
            if (A==null)
            {
                return 1;
            }
            if (Check(A, long.MinValue, long.MaxValue))
                return 1;
            else
                return 0;
            
        }

        private bool Check(TreeNode A, long minVal, long maxVal)
        {
            if(A==null)
            {
                return true;
            }

            if(A.val<=minVal || A.val>=maxVal)
            {
                return false;
            }
           if( Check(A.left, minVal, A.val) &&
            Check(A.right, A.val, maxVal))
            {
                return true;
            }
            return false;
        }

        public TreeNode BinaryTreeFromArray(List<int> A)
        {
            if (A.Count==0)
            {
                return null;
            }
            return CreateTree(A, 0, A.Count - 1);
        }

        private TreeNode CreateTree(List<int> A, int s, int e)
        {
            if(s>e)
            {
                return null;
            }
            int mid = (s + e) / 2;
            TreeNode root = new TreeNode(A[mid], null, null);
            root.left = CreateTree(A, s, mid - 1);
            root.right = CreateTree(A, mid + 1, e);
            return root;
        }

        public int FindLargestBST(TreeNode root)
        {
            if(root==null)
            {
                return 0;
            }
            if(IsValidBST(root.left)==1 && IsValidBST(root.right)==1)
            {
                if(root.left!=null && root.left.val>=root.val)
                {
                    return Math.Max(FindLargestBST(root.left), FindLargestBST(root.right));
                }

                if(root.right!=null && root.right.val<=root.val)
                {
                    return Math.Max(FindLargestBST(root.left), FindLargestBST(root.right));
                }

                return 1 + Math.Max(FindLargestBST(root.left), FindLargestBST(root.right));
            }
            return Math.Max(FindLargestBST(root.left),FindLargestBST(root.right));
        }

        //private int ValidBSTLength(TreeNode root,int minVal, int maxVal)
        //{
        //    if(root==null)
        //    {
        //        return 0;
        //    }
        //    if(root.left.val>minVal && root.right.val<maxVal)
        //    {

        //    }
        //}
    }
}
