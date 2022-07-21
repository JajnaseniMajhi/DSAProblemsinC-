using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class Heap
    {
         public List<int> heapList;
         public int size;
        public Heap(int size)
        {
            heapList = new List<int>(size);
            size = 0;
        }

        //Create a minheap
        public void CreateMinHeap(List<int> A)
        {
            for(int i=0;i<A.Count; i++)
            {
                InserttoMinHeap(A[i]);
            }
        }
        
        //Create a maxheap
        public void CreateMaxHeap(List<int> A)
        {
            for(int i=0;i<A.Count;i++)
            {
                InserttoMaxHeap(A[i]);
            }
        }

        //InsertSingleelemnt to minHeap
        public void InserttoMinHeap(int element)
        {
            heapList.Add(element);
            int currIndex = heapList.Count - 1;
            while (currIndex > 0)
            {
                int parentIndex = (currIndex - 1) / 2;
                if (heapList[currIndex] < heapList[parentIndex])
                {
                    swap(currIndex, parentIndex);
                    currIndex = parentIndex;
                }
                else
                {
                    return;
                }
            }
        }


        //InsertSingleElement to maxHeap
        public void InserttoMaxHeap(int element)
        {
            heapList.Add(element);
            int currIndex = heapList.Count - 1;
            while(currIndex>0)
            {
                int parentIndex=(currIndex-1)/2;
                if(heapList[currIndex] > heapList[parentIndex])
                {
                    swap(currIndex, parentIndex);
                    currIndex=parentIndex;
                }
                else
                {
                    return;
                }
            }
        }


        //GetMaximum from MaxHeap

        public int getMaximumfromMaxHeap()
        {
            int x = int.MinValue;
            
            if (heapList.Count>0)
            {
                int size = heapList.Count;
                x = heapList[0];
                // swap last element and max element which is the top one
                swap(0, size-1);
                heapList.RemoveAt(size - 1);
                size--;

                int i = 0;

                while ((2 * i) + 1 < size)
                {
                    int lIndex = (2 * i) + 1;
                    int rIndex = (2 * i) + 2;
                    int maxElement = Math.Max(heapList[lIndex], heapList[i]);
                    if (rIndex < size)
                    {
                        maxElement = Math.Max(maxElement, heapList[rIndex]);
                    }

                    if (maxElement == heapList[i])
                    {
                        break;
                    }
                    else if (maxElement == heapList[lIndex])
                    {
                        swap(i, lIndex);
                        i = lIndex;
                    }
                    else if (rIndex < size && maxElement == heapList[rIndex])
                    {
                        swap(i, rIndex);
                        i = rIndex;
                    }
                }
            }
            return x;
        }

        //GetMinimum from MinHeap
        public int getMinimumFromMinHeap()
        {
            int minimumValue = int.MaxValue;
            int size= heapList.Count;
            if (heapList.Count>0)
            {
                minimumValue = heapList[0];
                swap(0, size - 1);
                heapList.RemoveAt(size - 1);
                size--;

                int i = 0;
                while((2*i)+1<size)
                {
                    int lIndex = (2 * i) + 1;
                    int rIndex = (2 * i) + 2;
                    int minElement = Math.Min(heapList[i], heapList[lIndex]);
                    if(rIndex<size)
                    {
                        minElement = Math.Min(minElement, heapList[rIndex]);
                    }

                    if (minElement == heapList[i])
                    {
                        break;
                    }
                    if (minElement == heapList[lIndex])
                    {
                        swap(i, lIndex);
                        i = lIndex;
                    }

                    if (rIndex<size && minElement==heapList[rIndex])
                    {
                        swap(i, rIndex);
                        i = rIndex;
                    }
                }

            }
            return minimumValue;

        }

        private void swap(int firstIndex, int secondIndex)
        {
            int temp = heapList[firstIndex];
            heapList[firstIndex] = heapList[secondIndex];
            heapList[secondIndex] = temp;
        }

    }
}
