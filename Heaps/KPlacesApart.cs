using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class KPlacesApart
    {
        public List<int> Solve(List<int> A, int B)
        {
            List<int> result = new List<int>();
            Heap minHeap = new Heap(0);
            for (int i=0; i <=B; i++)
            {
                minHeap.InserttoMinHeap(A[i]);
            }

            result.Add(minHeap.getMinimumFromMinHeap());

            for(int j=B+1; j<A.Count;j++)
            {
                minHeap.InserttoMinHeap(A[j]);
                result.Add(minHeap.getMinimumFromMinHeap());

            }
            
            while(minHeap.heapList.Count>0)
            {
                result.Add(minHeap.getMinimumFromMinHeap());
            }
            return result;
        }
    }
}
