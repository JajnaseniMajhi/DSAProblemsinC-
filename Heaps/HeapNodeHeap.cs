using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class HeapNode
    {
        int data;
        int original;
        public HeapNode(int val)
        {
            this.data = val;
            this.original = val;
        }
        public int updateData()
        {
            this.data += this.original;
            return this.data;
        }
        public int getCurrentVal()
        {
            return this.data + this.original;
        }
    }
    public class HeapNodeHeap
    {
        private List<HeapNode> heapList = new List<HeapNode>();

        public int GetSize()
        {
            return heapList.Count;
        }

        public HeapNode GetMinimum()
        {
            return this.heapList.Count > 0 ? this.heapList[0] : default(HeapNode);
        }

        public void InsertToMinHeap(HeapNode item)
        {
            heapList.Add(item);
            this.HeapifyUp(heapList.Count - 1);
        }

        public HeapNode PopMin()
        {
            if (heapList.Count > 0)
            {
                HeapNode item = heapList[0];
                heapList[0] = heapList[heapList.Count - 1];
                heapList.RemoveAt(heapList.Count - 1);

                this.HeapifyDown(0);
                return item;
            }

            throw new InvalidOperationException("no element in heap");
        }

        private void HeapifyUp(int index)
        {
            var parent = this.GetParent(index);
            if (parent >= 0 && (heapList[index].getCurrentVal() < heapList[parent].getCurrentVal()))
            {
                var temp = heapList[index];
                heapList[index] = heapList[parent];
                heapList[parent] = temp;

                this.HeapifyUp(parent);
            }
        }

        private void HeapifyDown(int index)
        {
            var smallest = index;

            var left = this.GetLeft(index);
            var right = this.GetRight(index);

            if (left < this.GetSize() && (heapList[left].getCurrentVal()< heapList[index].getCurrentVal()))
            {
                smallest = left;
            }

            if (right < this.GetSize() && (heapList[right].getCurrentVal() < heapList[smallest].getCurrentVal()))
            {
                smallest = right;
            }

            if (smallest != index)
            {
                var temp = heapList[index];
                heapList[index] = heapList[smallest];
                heapList[smallest] = temp;

                this.HeapifyDown(smallest);
            }

        }

        private int GetParent(int index)
        {
            if (index <= 0)
            {
                return -1;
            }

            return (index - 1) / 2;
        }

        private int GetLeft(int index)
        {
            return 2 * index + 1;
        }

        private int GetRight(int index)
        {
            return 2 * index + 2;
        }
    }
}
