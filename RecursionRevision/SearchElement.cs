using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionRevision
{
    public class SearchElement
    {
        public bool IsFound(List<int> A, int target, int index)
        {
            if(index==A.Count)
            {
                return false;
            }

            if (A[index]==target)
            {
                return true;
            }

            return IsFound(A, target, index+1);
        }
    }
}
