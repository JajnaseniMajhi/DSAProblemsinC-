using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject.MorrisTraversal
{
    public class MorrisTraversalProblems
    {
        public void PrintMorrisInOrder(TreeNode A)
        {
            if(A==null)
            {
                return ;
            }
            TreeNode curr = A;
            while(curr!=null)
            {
                if(curr.left==null)
                {
                    Console.WriteLine(curr.val);
                    curr = curr.right;
                }
                else
                {
                    TreeNode temp = curr.left;
                    while(temp.right!=null && temp.right!=curr)
                    {
                        temp = temp.right;
                    }
                    if(temp.right==null)
                    {
                        temp.right = curr;
                        curr = curr.left;
                    }
                    if(temp.right==curr)
                    {
                        temp.right = null;
                        Console.WriteLine(curr.val);
                        curr = curr.right;
                    }
                }
            }
        }

        public void PrintMorrisPreOrder(TreeNode A)
        {
            if (A==null)
            {
                return;
            }
            TreeNode curr = A;
            while(curr !=null)
            {
                if(curr.left==null)
                {
                    Console.WriteLine(curr.val);
                    curr = curr.right;
                }
                else
                {
                    TreeNode temp= curr.left;
                    while(temp.right!=null   && temp.right!=curr)
                    {
                        temp= temp.right;
                    }

                    if(temp.right==null)
                    {
                        temp.right = curr;
                        Console.WriteLine(curr.val);
                        curr = curr.left;
                    }
                    if(temp.right==curr)
                    {
                        temp.right = null;
                        curr = curr.right;
                    }
                }
            }
        }
    }
}
