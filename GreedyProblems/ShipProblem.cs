using Heaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyProblems
{
    public class ShipProblem
    {
        public  List<int> Solve(int A, int B, List<int> C)
            {
            //Create maxHeap to get maximum
            Heap maxHeap = new Heap(0);
            //Create minHeap to get minimum
            Heap minHeap = new Heap(0);
            for(int i=0; i<B;i++)
            {
                maxHeap.InserttoMaxHeap(C[i]);
                minHeap.InserttoMinHeap(C[i]);
            }
            int maxMoney = 0;
            for (int i=0; i<A;i++)
            {
                int value = maxHeap.getMaximumfromMaxHeap();
                maxMoney = maxMoney + value;
                if((value-1)!=0)
                {
                    maxHeap.InserttoMaxHeap(value - 1);
                }
            }

            int minMoney = 0;
            for (int i = 0; i < A; i++)
            {
                int value = minHeap.getMinimumFromMinHeap();
                minMoney = minMoney + value;
                if ((value - 1) != 0)
                {
                    minHeap.InserttoMinHeap(value - 1);
                }
            }


            List<int> result = new List<int>() { maxMoney, minMoney };
            return result;

        }
    }
}
