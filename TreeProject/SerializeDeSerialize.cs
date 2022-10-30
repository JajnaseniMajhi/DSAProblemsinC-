using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public class SerializeDeSerialize
    {
        public TreeNode DeSearialize(List<int> A)
        {
            if(A.Count==0)
            {
                return null;
            }

            Queue<TreeNode> _queue = new Queue<TreeNode>();

            TreeNode root = new TreeNode(A[0],null,null);
            _queue.Enqueue(root);
            for(int i=1; i<A.Count-1;i=i+2)
            {
                TreeNode temp = _queue.Dequeue();
                if (A[i]!=-1)
                {
                    TreeNode left = new TreeNode(A[i], null, null);
                    temp.left= left;
                    _queue.Enqueue(left);
                }
                if (A[i+1] != -1)
                {
                    TreeNode right = new TreeNode(A[i+1], null, null);
                    temp.right = right;
                    _queue.Enqueue(right);
                }

            }

            return root;
        }
    
        public List<int> Serialize(TreeNode root)
        {
            var result = new List<int>();
            if (root==null)
            {
                return null;
            }

            Queue<TreeNode> _queue = new Queue<TreeNode>();
            _queue.Enqueue(root);
            // _queue.Enqueue(null);
            result.Add(root.val);
            while(_queue.Count>0)
            {
               // var row= 
                var temp = _queue.Dequeue();
               // result.Add(temp.val);
                if(temp.left!=null)
                {
                    _queue.Enqueue(temp.left);
                    result.Add(temp.left.val);
                }
                else
                {
                    result.Add(-1);
                }
                if (temp.right != null)
                {
                    _queue.Enqueue(temp.right);
                    result.Add(temp.right.val);
                }
                else
                {
                    result.Add(-1);
                }
            }

            return result;
        }
    
    }
}
