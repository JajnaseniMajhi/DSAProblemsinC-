using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    //Given an array A of N numbers, you have to perform B operations.In each operation, you have to pick any one of the N elements and add the original value(value stored at the index before we did any operations) to its current value.You can choose any of the N elements in each operation.

    //Perform B operations in such a way that the largest element of the modified array(after B operations) is minimized.
    //Find the minimum possible largest element after B operations.
    public class MinimimumLargestElement
    {
        public int Solve(List<int> A, int B)
        {
            if (A.Count == 0)
            {
                return 0;
            }
            //Create min heap
            HeapWithIndexMapping heapWithIndexMapping = new HeapWithIndexMapping();
            int maxValue = int.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                heapWithIndexMapping.InsertToMinHeap(i, 2* A[i],A);
                maxValue = Math.Max(maxValue, A[i]);
            }

            List<int> curr = A;

            //Get minimum with index

            while (B>1)
            {
                var minElement = heapWithIndexMapping.GetMinimunFromHeap();
                int index = minElement.Key;
                curr[index] += A[index];
                maxValue = Math.Max(curr[index], maxValue);
                heapWithIndexMapping.InsertToMinHeap(minElement.Key, curr[index],A);
                B = B - 1;
            }
            int ans = int.MinValue;
            for (int i = 0; i < curr.Count; i++) ans = Math.Max(ans, curr[i]);

            return ans;
        }
    }
}

