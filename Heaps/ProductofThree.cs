using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class ProductofThree
    {
        public List<int> solve(List<int> A)
        {
            List<int> result = new List<int>();
            Heap minHeap = new Heap(0);
            int product = 1;
            for(int i=0;i<3;i++)
            {
                result.Add(-1);
                minHeap.InserttoMinHeap(A[i]);
                product = product * A[i];
            }
            result[2]=product;

            for(int k=3; k<A.Count;k++)
            {
                int minElement = minHeap.getMinimumFromMinHeap();
                if (A[k]>minElement)
                {
                    minHeap.InserttoMinHeap(A[k]);
                    product = product * A[k] / minElement;
                    
                }
                else
                {
                    minHeap.InserttoMinHeap(minElement);
                }
                result.Add(product);
                
            }
            return result;
        }
    }
}
