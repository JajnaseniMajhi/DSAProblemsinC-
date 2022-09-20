using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision.Sorting
{
   // Given an array A of non-negative integers of size N.Find the minimum sub-array Al, Al+1 ,..., Ar such that if we sort(in ascending order) that sub-array, then the whole array should get sorted.If A is already sorted, output -1.
    public class MakeCompleteArraySorted
    {
        public List<int> FindUnSort(List<int> A)
        {
            int n = A.Count;
            int sValue = int.MaxValue;
            int eValue = int.MinValue;

            for (int i = 1; i < n; i++)
            {
                if (A[i] < A[i - 1])
                {
                    sValue = Math.Min(sValue, A[i]);
                }
            }
            if (sValue == int.MaxValue)
            {
                return new List<int> { -1 };
            }

            for (int i = n - 2; i >= 0; i--)
            {
                if (A[i] > A[i + 1])
                {
                    eValue = Math.Max(eValue, A[i]);
                }
            }

            int lo = -1, hi = -1;
            for (int i = 0; i < n; i++)
            {
                if (sValue < A[i])
                {
                    lo = i;
                    break;
                }
            }
            for (int i = n - 1; i >= 0; i--)
            {
                if (eValue > A[i])
                {
                    hi = i;
                    break;
                }
            }

            return new List<int> { lo, hi };
        }
    }
}
