using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class HeapWithIndexMapping
    {
        public List<KeyValuePair<int,int>> heapListWithIndex;
        public HeapWithIndexMapping()
        {
            heapListWithIndex = new List<KeyValuePair<int,int>>();
        }

        public void InsertToMinHeap(int index, int element, List<int> A)
        {
            heapListWithIndex.Add(new KeyValuePair<int,int>(index, element));
            int currIndex = heapListWithIndex.Count - 1;
            while (currIndex > 0)
            {
                int parentIndex = (currIndex - 1) / 2;
                if (heapListWithIndex[currIndex].Value < heapListWithIndex[parentIndex].Value)
                {
                    Swap(currIndex, parentIndex);
                    currIndex = parentIndex;
                }
                else if(heapListWithIndex[currIndex].Value == heapListWithIndex[parentIndex].Value)
                {
                    if (A[heapListWithIndex[currIndex].Key] < A[heapListWithIndex[parentIndex].Key])
                        Swap(currIndex, parentIndex);
                    currIndex = parentIndex;
                }
                else
                {
                    return;
                }
            }

        }

        public KeyValuePair<int,int>  GetMinimunFromHeap()
        {
            KeyValuePair<int, int> minimumValue= new KeyValuePair<int,int>(-1,int.MinValue);
            int size = heapListWithIndex.Count;
            if (heapListWithIndex.Count > 0)
            {
                minimumValue = heapListWithIndex[0];
                Swap(0, size - 1);
                heapListWithIndex.RemoveAt(size - 1);
                size--;

                int i = 0;
                while ((2 * i) + 1 < size)
                {
                    int lIndex = (2 * i) + 1;
                    int rIndex = (2 * i) + 2;
                    int minElement = Math.Min(heapListWithIndex[i].Value, heapListWithIndex[lIndex].Value);
                    if (rIndex < size)
                    {
                        minElement = Math.Min(minElement, heapListWithIndex[rIndex].Value);
                    }

                    if (minElement == heapListWithIndex[i].Value)
                    {
                        break;
                    }
                    if (minElement == heapListWithIndex[lIndex].Value)
                    {
                        Swap(i, lIndex);
                        i = lIndex;
                    }

                    if (rIndex < size && minElement == heapListWithIndex[rIndex].Value)
                    {
                        Swap(i, rIndex);
                        i = rIndex;
                    }
                }

            }
            return minimumValue;
        }

        public void Swap(int index, int parentIndex)
        {
            KeyValuePair<int,int> curr = heapListWithIndex[index];
            heapListWithIndex[index] = heapListWithIndex[parentIndex];
            heapListWithIndex[parentIndex] = curr;
        }
    }


}
