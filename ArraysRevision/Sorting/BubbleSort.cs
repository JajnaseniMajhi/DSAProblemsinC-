using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision.Sorting
{
    public class BubbleSort
    {
        public void DoBubbleSort(List<int> A)
        {
            int size= A.Count;
            for(int i=0; i<size; i++)
            {
                for (int j=0; j<size-i-1;j++)
                {
                    if (A[j] > A[j+1])

                    {
                        //swap
                        int temp= A[j];
                        A[j] = A[j + 1];
                        A[j+1] = temp;
                    }
                }
            }

            for(int i=0;i<size; i++)
            {
                Console.Write(A[i] + " ");
            }

        }
    }
}
