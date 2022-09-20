using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPractice
{
//    Given a sorted array of integers A(0 based index) of size N, find the starting and the ending position of a given integer B in array A.

//Your algorithm's runtime complexity must be in the order of O(log n).

//Algorithm: 
//    step-1 FInd a single element
//    step-2 Find in the left
//    step-3 Find in the right
//    Need to use BinarySearch as logn complexity


    internal class SearchForARange
    {
        public List<int> SearchRange(List<int> A,int B)
        {
            int l = 0;
            int r = A.Count - 1;
            int s = 0;
            int e = 0;
            List<int> result = new List<int>();
            //FInd in the left
            while(l<=r)
            {
                int mid = (l + r) / 2;

                if (A[mid]==B)
                {
                    s = mid;
                    r = mid - 1;
                }
                else if (A[mid]>B)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            result.Add(s);
            l = 0;
            r = A.Count - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (A[mid] == B)
                {
                    e = mid;
                    l = mid+ 1;
                }
                else if (A[mid] > B)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            result.Add(e);

            return result;
        }
    }
}
