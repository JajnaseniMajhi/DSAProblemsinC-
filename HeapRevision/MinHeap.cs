using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapRevision
{
    public class MinHeap
    {
        public List<int> minHeapList;
        public int size;

        public MinHeap()
        {
            minHeapList = new List<int>();
            size = 0;
        }

        //Creaate a minheap

        public void CreateMinHeap(List<int> A)
        {
            for(int i=0; i<A.Count; i++)
            {
                //Insert A[i] to min heap
                InsertToMinHeap(A[i]);
            }
        }

        public void InsertToMinHeap(int element)
        {
            minHeapList.Add(element);
            int currIndex= minHeapList.Count-1;
            int parentIndex = (currIndex - 1) / 2;
            while (currIndex > 0)
            {
                if (minHeapList[currIndex]>minHeapList[parentIndex])
                {
                    //swap both the element
                    int temp = minHeapList[currIndex];
                    minHeapList[currIndex] = minHeapList[parentIndex];
                    minHeapList[parentIndex] = temp;
                    currIndex = parentIndex;
                }
            }
        }

        public int GetMinimumFromMinHeap()
        {
            int size = minHeapList.Count;
            int minValue = int.MaxValue;
            if (size > 0)
            {
                 minValue = minHeapList[0];
                //swap minelement with last element
                int temp = minHeapList[0];
                minHeapList[0] = minHeapList[minHeapList.Count - 1];
                minHeapList[minHeapList.Count - 1] = temp;
                minHeapList.RemoveAt(minHeapList.Count - 1);
                size = size - 1;
                //Meanify again
                int currIndex = 0;
                while ((2 * currIndex + 1) < size)
                {
                    int lIndex = 2 * currIndex + 1;
                    int rIndex = 2 * currIndex + 2;
                    int minElement = Math.Min(minHeapList[currIndex], minHeapList[lIndex]);
                    if (rIndex < size)
                    {
                        minElement = Math.Min(minElement, minHeapList[rIndex]);
                    }
                    if (minElement == minHeapList[currIndex])
                    {
                        break;
                    }

                    if (minElement == minHeapList[lIndex])
                    {
                        //Swap
                        temp = minElement;
                        minHeapList[lIndex] = minHeapList[currIndex];
                        minHeapList[currIndex] = temp;
                        currIndex = lIndex;
                    }
                    if (minElement == minHeapList[rIndex])
                    {
                        //Swap
                        temp = minHeapList[rIndex];
                        minHeapList[rIndex] = minHeapList[currIndex];
                        minHeapList[currIndex] = temp;
                        currIndex = rIndex;
                    }


                }
            }

            return minValue;
        }
    }
}
