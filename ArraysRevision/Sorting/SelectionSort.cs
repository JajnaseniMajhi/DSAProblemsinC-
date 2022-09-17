using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision.Sorting
{
    public class SelectionSort
    {
        public void DoSelectionSort(List<int> A)
        {

            int size = A.Count;

            for (int i = 0; i < size - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (A[j] < A[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // swap A[i] with minimum element
                int temp = A[i];
                A[i] = A[minIndex];
                A[minIndex] = temp;
            }


            for (int i = 0; i < size; i++)
            {
                Console.Write(A[i] + " ");
            }

        }
    }
}
