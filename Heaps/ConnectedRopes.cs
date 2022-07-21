using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public  class ConnectedRopes
    {
        public int Solve(List<int> A)
        {
            int result = 0;
            Heap minHeap = new Heap(0);
            minHeap.CreateMinHeap(A);
            int size = A.Count;
            for (int i=0;i<size-1;i++)
            {
                int firstMin = minHeap.getMinimumFromMinHeap();
                int secondMin = minHeap.getMinimumFromMinHeap();
                minHeap.InserttoMinHeap(firstMin + secondMin);
                result= result+firstMin+secondMin;

            }
            return result;

       }
    }
}
