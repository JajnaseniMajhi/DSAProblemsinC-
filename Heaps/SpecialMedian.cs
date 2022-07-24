using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class SpecialMedian
    {
        
        public int solve(List<int> A)
        {
            Heap leftMaxHeap = new Heap(0);
            Heap rightMinHeap = new Heap(0);
            int size = A.Count;
            leftMaxHeap.InserttoMaxHeap(A[0]);
            int currMedian = A[0];
            //Check for left side
            for (int i = 1; i < A.Count; i++)
            {
               
                if (A[i]==currMedian)
                {
                    return 1;
                }
                if (A[i]>currMedian)
                {
                    rightMinHeap.InserttoMinHeap(A[i]);
                }
                else
                {
                    leftMaxHeap.InserttoMaxHeap(A[i]);
                }

                if(rightMinHeap.heapList.Count>leftMaxHeap.heapList.Count)
                {
                  int value=  rightMinHeap.getMinimumFromMinHeap();
                  leftMaxHeap.InserttoMaxHeap(value);
                }
                else if ((leftMaxHeap.heapList.Count-rightMinHeap.heapList.Count)>1)
                {
                    rightMinHeap.InserttoMinHeap(leftMaxHeap.getMaximumfromMaxHeap());
                }

                if(leftMaxHeap.heapList.Count==rightMinHeap.heapList.Count)
                {
                    int leftMax = leftMaxHeap.getMaximumfromMaxHeap();
                    int rightMin = rightMinHeap.getMinimumFromMinHeap();
                    currMedian = (leftMax + rightMin) / 2;

                    leftMaxHeap.InserttoMaxHeap(leftMax);
                    rightMinHeap.InserttoMinHeap(rightMin);
                }
                else
                {
                    currMedian = leftMaxHeap.getMaximumfromMaxHeap();
                    leftMaxHeap.InserttoMaxHeap(currMedian);
                }
                //if (currMedian == A[i])
                //{
                //    return 1;
                //}

            }

           
           //Check for right side
            leftMaxHeap= new Heap(0);
            rightMinHeap = new Heap(0);
            leftMaxHeap.InserttoMaxHeap(A[size - 1]);
            currMedian = A[size - 1];
            for (int i = size-2; i>=0; i--)
            {
                
                if (A[i] == currMedian && currMedian !=0)
                {
                    return 1;
                }
                if (A[i] > currMedian)
                {
                    rightMinHeap.InserttoMinHeap(A[i]);
                }
                else
                {
                    leftMaxHeap.InserttoMaxHeap(A[i]);
                }

                if (rightMinHeap.heapList.Count > leftMaxHeap.heapList.Count)
                {
                    int value = rightMinHeap.getMinimumFromMinHeap();
                    leftMaxHeap.InserttoMaxHeap(value);
                }
                else if ((leftMaxHeap.heapList.Count - rightMinHeap.heapList.Count) > 1)
                {
                    rightMinHeap.InserttoMinHeap(leftMaxHeap.getMaximumfromMaxHeap());
                }

                if (leftMaxHeap.heapList.Count == rightMinHeap.heapList.Count)
                {
                    int leftMax = leftMaxHeap.getMaximumfromMaxHeap();
                    int rightMin = rightMinHeap.getMinimumFromMinHeap();
                    currMedian = (leftMax + rightMin) / 2;

                    leftMaxHeap.InserttoMaxHeap(leftMax);
                    rightMinHeap.InserttoMinHeap(rightMin);
                }
                else
                {
                    currMedian = leftMaxHeap.getMaximumfromMaxHeap();
                    leftMaxHeap.InserttoMaxHeap(currMedian);
                }
            }


            return 0;
        }
    }
}

