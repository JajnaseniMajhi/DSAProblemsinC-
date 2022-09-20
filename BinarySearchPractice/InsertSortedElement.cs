using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPractice
{
//Given a sorted array A of size N and a target value B, return the index(0-based indexing) if the target is found.
//If not, return the index where it would be if it were inserted in order.

    //Same problem as find the floor of a target
    //Insert the element after te floor of the given element

    internal class InsertSortedElement
    {
        public int GetInsertSortedElement(List<int>A,int B)
        {
            int l = 0;
            int r = A.Count - 1;
            int result = -1;
            while(l<=r)
            {
                int mid = l + ((r - l) / 2);
                if (A[mid]==B)
                    return mid;

                if (A[mid]<B)
                {
                    result = mid+1;
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return result+1;
        }
    }
}
