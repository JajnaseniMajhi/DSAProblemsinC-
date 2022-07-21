using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class MaximumSumAfterBNegations
    {
        public int Solve(List<int> A, int B)
        {
            int sum = 0;
            Heap minHeap = new Heap(0);
            minHeap.CreateMinHeap(A);
            int i = B;
            while(i>0)
            {
                int minElement = minHeap.getMinimumFromMinHeap();
                if (minElement==0)
                {
                    break;
                }
                else if (minElement<0)
                {
                    minHeap.InserttoMinHeap(-minElement);
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        minHeap.InserttoMinHeap(minElement);
                    }
                    else
                    {
                        minHeap.InserttoMinHeap(-minElement);
                    }
                    break;
                }
                i = i - 1;
            }

            for(int p=0;p<minHeap.heapList.Count;p++)
            {
                sum = sum + minHeap.heapList[p];
            }

            return sum;

        }
    }
}
