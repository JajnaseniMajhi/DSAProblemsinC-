using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision.Sorting
{
    public class QuickSort
    {
        //// Divide and conquer based on a pivot element
        //// The pivot elemnt can be the first elemnt or last element

        public void DoQuickSortPivotFirstElement(List<int> A)
        {
            QuickSortLogic(A, 0, A.Count - 1);
            for (int i = 0; i < A.Count; i++)
            {
                Console.Write(A[i] + " ");
            }

        }

        public int Partition(List<int> A, int l, int h)
        {
            int pivot;
            pivot = A[l];
            while (true)
            {
                while (A[l] < pivot)
                {
                    l++;
                }
                while (A[h] > pivot)
                {
                    h--;
                }
                if (l < h)
                {
                    int temp = A[h];
                    A[h] = A[l];
                    A[l] = temp;
                }
                else
                {
                    return h;
                }
            }


        }

        public void QuickSortLogic(List<int> A, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(A, left, right);
                if (pivot > 1)
                {
                    QuickSortLogic(A, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSortLogic(A, pivot + 1, right);
                }
            }
        }
    }
}
