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

        //public void DoQuickSortPivotFirstElement(List<int> A)
        //{
        //    QuickSortLogic(A, 0, A.Count - 1);
        //    for(int i=0; i<A.Count; i++)
        //    {
        //        Console.Write(A[i] + " ");
        //    }

        //}
        
        //public int Partition(List<int> A, int l, int h)
        //{
        //    int i = l;
        //    int j = h;
        //    int pivot = A[l];
        //    while(i< j)
        //    {
        //        while (pivot >= A[i])
        //        {
        //            i = i + 1;
        //        }

        //        while (pivot < A[j])
        //        {
        //            j = j - 1;
        //        }
        //        if(i<j)
        //        {
        //            int temp = A[i];
        //            A[i] = A[j];
        //            A[j] = temp;
        //        }
        //    }
        //    int t = A[l];
        //    A[l] = A[j];
        //    A[j] = t;
        //    return j;



        //}

        //public void QuickSortLogic(List<int> A, int l, int h)
        //{
        //    if(l<h)
        //    {
        //        //Do partition around the pivot
        //        int pivot = Partition(A, l, h);
        //        //QuickSort left child
        //        QuickSortLogic(A, l, pivot - 1);
        //        //QuickSort Right child
        //        QuickSortLogic(A, pivot + 1, h);

        //    }
        //}
    }
}
