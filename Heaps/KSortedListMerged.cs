using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
   //public class ListNode:IComparable
   // {
   //  public int val;
   //  public ListNode next;
   //  public ListNode(int x) { val = x; next = null; }
   //     public int CompareTo(object obj)
   //     {
            
   //             ListNode node = (ListNode)obj;
   //             return val.CompareTo(node.val);
            
   //     }
   // }
    public class KSortedListMerged
    {
        public ListNode mergeKLists(List<ListNode> A)
        {
            List<ListNode> result = new List<ListNode>();
            HeapWithListNode minHeap = new HeapWithListNode();
            foreach(var node in A)
            {
                minHeap.InsertToMinHeap(node);
            }
            
            ListNode PrevNode = null;


            while (minHeap.GetSize()>0)
            {
                ListNode minNode = minHeap.GetMinimum();
                if(PrevNode!=null)
                PrevNode.next = minNode;
                result.Add(minNode);
                minHeap.PopMin();
                if(minNode.next!=null)
                {
                    minHeap.InsertToMinHeap(minNode.next);
                }
                 PrevNode = minNode;
            }

            return result[0];
        }
    }
}
