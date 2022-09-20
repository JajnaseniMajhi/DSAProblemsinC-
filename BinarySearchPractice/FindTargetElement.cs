using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPractice
{
    public class FindTargetElement
    {
        // FInd an element in an sorted  array with TC logn
        //Use Binry serach to find an element in an array with TC logn

        public bool FindATarget(List<int> A, int k)
        {
            int l = 0;
            int r = A.Count - 1;

            while(l<=r)
            {
                int mid = l + ((r-l) / 2);
                if (A[mid] == k)
                    return true;
                if (A[mid]>k)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }

            }

            return false;
        }
    }
}
