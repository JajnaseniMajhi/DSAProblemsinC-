using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionRevision
{
    public class CheckArraySorted
    {
        public bool Issorted(List<int> A, int index)
        {
            if(index==A.Count-1)
            {
                return true;
            }
            if (A[index] > A[index + 1])
                return false;
            else
               
                return Issorted(A, index + 1);
            
             
        }
    }
}
