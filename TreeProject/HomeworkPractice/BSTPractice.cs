using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject.HomeworkPractice
{
    public class BSTPractice
    {
        //Given preorder traversal of a binary tree, check if it is possible that 
        //    it is also a preorder traversal of a Binary Search Tree(BST),
        //    where each internal node(non-leaf nodes) have exactly one child.

        public string Solve(List<int> A)
        {
            if (A.Count == 0)

            {
                return "NO";
            }

            int leftMin = int.MinValue;
            int rightMax = int.MaxValue;
            TreeNode root = new TreeNode(A[0], null, null); ;
            for(int i=1; i< A.Count-1; i++)
            {    
                 if (A[i]<root.val)
                {
                    rightMax = root.val;
                }
                else if (A[i]> root.val)
                {
                    leftMin = root.val;
                }
                if (A[i]<leftMin || A[i]>rightMax)
                {
                    return "NO";
                }

                
            }
            return "YES";



        }

        public int SolveRange(TreeNode A, int B, int C)
        {

            var temp = A;
            if (temp == null)
            {
                return 0;
            }
            if (B <= temp.val && temp.val <= C)
            {
                return (SolveRange(temp.left, B, C) + SolveRange(temp.right,B,C)+1);

            }
            else
            {
                return (SolveRange(temp.left, B, C) + SolveRange(temp.right, B, C));
            }

        }

        //Given a binary search tree A, where each node contains a positive integer, and an integer B, 
        //you have to find whether or not there exist two different nodes X and Y such that X.value + Y.value = B
        public bool Sum2T(TreeNode A, int B, HashSet<int> list)
        {
            if(A==null)
            {
                return false;
            }
            if(list.Contains(B-A.val))
            {
                return true;
            }
            else
            {
                list.Add(A.val);
                return Sum2T(A.left, B, list) || Sum2T(A.right, B, list);
            }

        }
    }
    }

