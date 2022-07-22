using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public  class RunningMedian
    {
        public List<int> solve(List<int> A)
        {
            //Create leftMaxheap
            //Create rightMinHeap
            Heap leftMaxHeap = new Heap(0);
            Heap rightMinHeap= new Heap(0);
            List<int> result = new List<int>();
            leftMaxHeap.InserttoMaxHeap(A[0]);
            result.Add(A[0]);
            for(int i=1;i<A.Count;i++)
            {
                int leftMax = leftMaxHeap.getMaximumfromMaxHeap();
                if (A[i]>leftMax)
                {
                    rightMinHeap.InserttoMinHeap(A[i]);
                    leftMaxHeap.InserttoMaxHeap(leftMax);
                }
                else
                {
                    leftMaxHeap.InserttoMaxHeap(A[i]);
                    leftMaxHeap.InserttoMaxHeap(leftMax);
                }
                if(leftMaxHeap.heapList.Count<rightMinHeap.heapList.Count)
                {
                    int rightmin = rightMinHeap.getMinimumFromMinHeap();
                    leftMaxHeap.InserttoMaxHeap(rightmin);
                }
                else if(leftMaxHeap.heapList.Count-rightMinHeap.heapList.Count>1)
                {
                    rightMinHeap.InserttoMinHeap(leftMaxHeap.getMaximumfromMaxHeap());
                }

                int size = i + 1;
                if(size==1)
                {
                    result.Add(A[0]);
                }

                else
                {
                    int median = leftMaxHeap.getMaximumfromMaxHeap();
                    result.Add(median);
                    leftMaxHeap.InserttoMaxHeap(median);
                }
                //else if (size%2==0)
                //{
                //    int rightmin = rightMinHeap.getMinimumFromMinHeap();
                //    int leftmax = leftMaxHeap.getMaximumfromMaxHeap();
                //    result.Add((rightmin+leftmax) / 2);
                //    rightMinHeap.InserttoMinHeap(rightmin);
                //    leftMaxHeap.InserttoMaxHeap(leftmax);
                //}
                //else
                //    {
                //    int leftmax = leftMaxHeap.getMaximumfromMaxHeap();
                //    result.Add(leftmax);
                //    leftMaxHeap.InserttoMaxHeap(leftmax);
                //}
                
            }


            return result;

        }
    }
}
