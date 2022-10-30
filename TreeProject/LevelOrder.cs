using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    public class LevelOrder
    {
        public List<List<int>> LvelOrderTraversal(TreeNode root)
        {
            var result = new List<List<int>>();
            Queue<TreeNode> _queue = new Queue<TreeNode>();
            _queue.Enqueue(root);
            _queue.Enqueue(null);
            var row = new List<int>();
            while(_queue.Count != 0)
            {
                TreeNode node = _queue.Dequeue();
                if (node == null)
                {
                    result.Add(row);
                    row = new List<int>();
                    if (_queue.Count > 0)
                    {
                        _queue.Enqueue(null);
                    }
                }
                else
                {
                    row.Add(node.val);

                    // Console.WriteLine(node.val);
                    if (node.left != null)
                    {
                        _queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        _queue.Enqueue(node.right);
                    }
                }
            }

            return result;
        }

        public List<int> solve(TreeNode A)
        {

            if (A == null)
                return null;
            var result = new List<int>();
            Queue<TreeNode> _queue = new Queue<TreeNode>();

            TreeNode prev = null;
            TreeNode temp = null;
            _queue.Enqueue(A);
            _queue.Enqueue(null);
            //result.Add(A.val);
            while (_queue.Count > 0)
            {
                prev = temp;
                temp = _queue.Dequeue();
               // prev = temp;

                if (temp == null)
                {
                    result.Add(prev.val);
                    if (_queue.Count > 0)
                    {
                        _queue.Enqueue(null);
                    }
                }
                else
                {
                    if (temp.left != null)
                    {
                        _queue.Enqueue(temp.left);
                    }
                    if (temp.right != null)
                    {
                        _queue.Enqueue(temp.right);
                    }
                }
            }
            return result;
        }

        public List<List<int>> VerticalOrderTraverse(TreeNode A)
        {
            if(A==null)
            {
                return null;
            }
            var result = new List<List<int>>();

            Queue<KeyValuePair<TreeNode, int>> _queue = new Queue<KeyValuePair<TreeNode, int>>();
            Dictionary<int, List<int>> mapLevel = new Dictionary<int, List<int>>();
            int minLevel = int.MaxValue;
            int maxLevel = int.MinValue;
            _queue.Enqueue(new KeyValuePair<TreeNode, int>(A, 0));
            while(_queue.Count>0)
            {
                var temp= _queue.Dequeue();
                var node = temp.Key;
                var level = temp.Value;
                minLevel = Math.Min(minLevel, level);
                maxLevel = Math.Max(maxLevel, level);
                if(mapLevel.ContainsKey(level))
                {
                    mapLevel[level].Add(node.val);
                }
                else
                {
                    mapLevel.Add(level, new List<int>() { node.val });
                }
                if (node.left!=null)
                {
                    _queue.Enqueue(new KeyValuePair<TreeNode, int>(node.left, level-1));

                }

                if (node.right != null)
                {
                    _queue.Enqueue(new KeyValuePair<TreeNode, int>(node.right, level+1));

                }
            }
            for(int i= minLevel; i<= maxLevel; i++)
            {
                result.Add(mapLevel[i]);
            }
               

           return result;
        }


        //IN topview, need to keep only the first element of the level,  no need to update the dictionary
        public List<int> TopView(TreeNode A)
        {
            if (A == null)
            {
                return null;
            }

            var result = new List<int>();

            Queue<KeyValuePair<TreeNode, int>> _queue = new Queue<KeyValuePair<TreeNode, int>>();
            _queue.Enqueue(new KeyValuePair<TreeNode, int>(A,0));

            SortedDictionary<int, int> topViewMap = new SortedDictionary<int, int>();

            while(_queue.Count>0)
            {
                var temp= _queue.Dequeue();
                var node = temp.Key;
                var level = temp.Value;
                if(!topViewMap.ContainsKey(level))
                {
                    topViewMap.Add(level, node.val);
                }

                if(node.left!=null)
                {
                    _queue.Enqueue(new KeyValuePair<TreeNode, int>(node.left, level - 1));
                }

                if(node.right!=null)
                {
                    _queue.Enqueue(new KeyValuePair<TreeNode, int>(node.right, level + 1));
                }

            }

            foreach(var value in topViewMap.Values )
                result.Add(value);

            return result;
        }

        public List<int> BottomView(TreeNode A)
        {
            if(A==null)
            {
                return null;
            }
            var result = new List<int>();

            Queue<KeyValuePair<TreeNode, int>> _queue = new Queue<KeyValuePair<TreeNode, int>>();
            _queue.Enqueue(new KeyValuePair<TreeNode, int>(A, 0));

            SortedDictionary<int, int> topViewMap = new SortedDictionary<int, int>();

            while (_queue.Count > 0)
            {
                var temp = _queue.Dequeue();
                var node = temp.Key;
                var level = temp.Value;
                if (!topViewMap.ContainsKey(level))
                {
                    topViewMap.Add(level, node.val);
                }
                else
                {
                    topViewMap[level] = node.val;
                }

                if (node.left != null)
                {
                    _queue.Enqueue(new KeyValuePair<TreeNode, int>(node.left, level - 1));
                }

                if (node.right != null)
                {
                    _queue.Enqueue(new KeyValuePair<TreeNode, int>(node.right, level + 1));
                }

            }

            foreach (var value in topViewMap.Values)
                result.Add(value);

            return result;
            return result;
        }
        
    }
}
