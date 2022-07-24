using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    class Solution
    {
        public int solve(List<int> A)
        {
            int medianLeft = CheckSpecialMedian(A);
            A.Reverse();
            int medianRight = CheckSpecialMedian(A);
            if (medianLeft == -1 && medianRight == -1)
            {
                return 0;
            }
            return 1;
        }
        private int CheckSpecialMedian(List<int> A)
        {
            decimal currentMedian = A[0];
            List<int> maxHeap = new List<int>();
            List<int> minHeap = new List<int>();
            maxHeap.Add(A[0]);
            for (int i = 1; i < A.Count; i++)
            {
                if (A[i] == currentMedian)
                {
                    return 1;
                }
                if (A[i] > maxHeap[0])
                {
                    InsertInMinHeapOneByOne(minHeap, A[i]);
                }
                else
                {
                    InsertInMaxHeapOneByOne(maxHeap, A[i]);
                }
                if (maxHeap.Count - minHeap.Count > 1)
                {
                    int elem = RemoveFromHeap(maxHeap);
                    InsertInMinHeapOneByOne(minHeap, elem);
                }
                else if (minHeap.Count > maxHeap.Count)
                {
                    int elem = RemoveFromMinHeap(minHeap);
                    InsertInMaxHeapOneByOne(maxHeap, elem);
                }
                if ((i + 1) % 2 == 0)
                {
                    currentMedian = maxHeap[0] + ((minHeap[0] - (decimal)maxHeap[0]) / 2);
                }
                else
                {
                    currentMedian = maxHeap[0];
                }
            }
            return -1;
        }
        private int RemoveFromHeap(List<int> arr)
        {
            int result = 0;
            if (arr.Count == 0)
            {
                return -1;
            }
            result = arr[0];
            Swap(arr, 0, arr.Count - 1);
            arr.RemoveAt(arr.Count - 1);
            int parentIndex = 0;
            int childOneIndex = parentIndex * 2 + 1;
            int childTwoIndex = parentIndex * 2 + 2;
            int greaterValueIndex = 0;
            if (childOneIndex >= arr.Count && childTwoIndex >= arr.Count)
            {
                greaterValueIndex = -1;
            }
            else
            {
                greaterValueIndex = childTwoIndex < arr.Count ? arr[childTwoIndex] > arr[childOneIndex] ? childTwoIndex : childOneIndex : childOneIndex;
            }
            while (greaterValueIndex != -1 && arr[parentIndex] < arr[greaterValueIndex])
            {
                Swap(arr, parentIndex, greaterValueIndex);
                parentIndex = greaterValueIndex;
                childOneIndex = parentIndex * 2 + 1;
                childTwoIndex = parentIndex * 2 + 2;
                if (childOneIndex >= arr.Count && childTwoIndex >= arr.Count)
                {
                    greaterValueIndex = -1;
                }
                else
                {
                    greaterValueIndex = childTwoIndex < arr.Count ? arr[childTwoIndex] > arr[childOneIndex] ? childTwoIndex : childOneIndex : childOneIndex;
                }
            }
            return result;
        }
        private int RemoveFromMinHeap(List<int> arr)
        {
            int result = 0;
            if (arr.Count == 0)
            {
                return -1;
            }
            result = arr[0];
            Swap(arr, 0, arr.Count - 1);
            arr.RemoveAt(arr.Count - 1);
            int parentIndex = 0;
            int childOneIndex = parentIndex * 2 + 1;
            int childTwoIndex = parentIndex * 2 + 2;
            int greaterValueIndex = 0;
            if (childOneIndex >= arr.Count && childTwoIndex >= arr.Count)
            {
                greaterValueIndex = -1;
            }
            else
            {
                greaterValueIndex = childTwoIndex < arr.Count ? arr[childTwoIndex] < arr[childOneIndex] ? childTwoIndex : childOneIndex : childOneIndex;
            }
            while (greaterValueIndex != -1 && arr[parentIndex] > arr[greaterValueIndex])
            {
                Swap(arr, parentIndex, greaterValueIndex);
                parentIndex = greaterValueIndex;
                childOneIndex = parentIndex * 2 + 1;
                childTwoIndex = parentIndex * 2 + 2;
                if (childOneIndex >= arr.Count && childTwoIndex >= arr.Count)
                {
                    greaterValueIndex = -1;
                }
                else
                {
                    greaterValueIndex = childTwoIndex < arr.Count ? arr[childTwoIndex] < arr[childOneIndex] ? childTwoIndex : childOneIndex : childOneIndex;
                }
            }
            return result;
        }
        private void InsertInMinHeapOneByOne(List<int> arr, int elem)
        {
            arr.Add(elem);
            int insertedIndex = arr.Count - 1;
            int parentIndex = (insertedIndex - 1) / 2;
            while (insertedIndex != 0 && arr[parentIndex] > arr[insertedIndex])
            {
                Swap(arr, parentIndex, insertedIndex);
                insertedIndex = parentIndex;
                parentIndex = (insertedIndex - 1) / 2;
            }
        }
        private void InsertInMaxHeapOneByOne(List<int> arr, int elem)
        {
            arr.Add(elem);
            int insertedIndex = arr.Count - 1;
            int parentIndex = (insertedIndex - 1) / 2;
            while (insertedIndex != 0 && arr[parentIndex] < arr[insertedIndex])
            {
                Swap(arr, parentIndex, insertedIndex);
                insertedIndex = parentIndex;
                parentIndex = (insertedIndex - 1) / 2;
            }
        }
        private void Swap(List<int> arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}

