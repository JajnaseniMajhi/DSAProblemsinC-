using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision.Sorting
{
    public class InsertionSort
    {
        // 5 6 3 4 2 9
        public void DoInsertionSort(List<int> A)
        {
            for(int i=1; i<A.Count; i++) 
            {
                for(int j=i-1;j>=0; j--)
                {
                    if (A[j] > A[j+1])
                    {
                        int temp= A[j];
                        A[j]=A[j+1];
                        A[j+1]=temp;
                    }
                }
            }

            for(int i=0; i<A.Count; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
    }
}
