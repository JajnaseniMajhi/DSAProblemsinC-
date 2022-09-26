using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPractice
{
    internal class SearchBiotonicArray
    {
        //BiotonicArray:  When elements starts decreasing after certain element
        //e.g 3 5 7 12 24 22 18 16 9 1 0

        //Algorithm:
        //step-1 first find the pivot element i.e 24 here
        // FInd in the left and find in the right accordingly
        public int solve(List<int> A, int B)
        {
            //step-1 find the pivot element
            int l = 0;
            int r = A.Count - 1;
            int max = -1;
            while(l<=r)
            {
                int mid = (l + r) / 2;
                if (A[mid] > A[mid+1])
                {
                    max=mid;
                    r = mid - 1;
                }
                else if(A[mid] < A[mid+1])
                {
                    l = mid + 1;
                }
            }

            Console.WriteLine(max);

            if (B == A[max])
            {
                return max;
            }
            if (B > A[max])
                return -1;
            //Find element in the left
            l = 0;
            r = max - 1;

            while(l<=r)
            {
                int mid = (l + r) / 2;
                if (A[mid] == B)
                    return mid;
                if (A[mid]>B)
                {
                    r = mid - 1;
                }
                else
                {
                    l=mid + 1;
                }
            }
            l = max + 1;
            r = A.Count - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (A[mid] == B)
                    return mid;
                if (A[mid] > B)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return -1;
        }
    }
}
