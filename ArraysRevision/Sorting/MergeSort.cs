using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision.Sorting
{
    public class MergeSort
    {
        public void DoMergeSort(List<int>A)
        {

            //step-1 devide the array till l==r

            //step-2 Merge the sorted array

            MergeSortLogic(A, 0, A.Count - 1);

            for(int i=0; i<A.Count;i++)
            {
                Console.Write(A[i] + " ");
            }

        }

        public void MergeSortLogic(List<int> A,int left, int right)
        {
            if (left == right)
                return;
            int mid= left+(right-left)/2;
            MergeSortLogic(A, left, mid);
            MergeSortLogic(A, mid + 1, right);
            MergeSortedArray(A, left, mid, right);
        }

        public void MergeSortedArray(List<int> A, int l,int mid, int r)
        {
            List<int> temp= new List<int>();
            int p1 = l;
            int p2 = mid + 1;

            while(p1<=mid && p2 <=r)
            {
                if (A[p1] < A[p2])
                {
                    temp.Add(A[p1]);
                    p1 = p1 + 1;
                }
                else
                {
                    temp.Add(A[p2]);
                    p2++;
                }
            }

            while(p1<=mid)
            {
                temp.Add(A[p1]);
                p1 = p1 + 1;
            }

            while(p2<=r)
            {
                temp.Add(A[p2]);
                p2 = p2 + 1;
            }

            for(int i=0; i< r-l+1; i++)
            {
                A[l + i] = temp[i];
            }
        }
    }
}
