using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public  class AthLargest
    {
        public List<int> Solve(int A, List<int> B)
        {
            List<int> result = new List<int>();
            Heap minHeap = new  Heap(0);
            for(int i=0; i<A; i++)
            {
                result.Add(-1);
                minHeap.InserttoMinHeap(B[i]);
            }

            int minimum= minHeap.getMinimumFromMinHeap();
            result[A - 1] = minimum;

            for (int j=A; j<B.Count; j++)
            {
                if (B[j]>minimum)
                {
                    minHeap.InserttoMinHeap(B[j]);
                   
                }
                else
                {
                    minHeap.InserttoMinHeap(minimum);
                }
                minimum = minHeap.getMinimumFromMinHeap();
                result.Add(minimum);
            }

            return result;


        }
    }
}
