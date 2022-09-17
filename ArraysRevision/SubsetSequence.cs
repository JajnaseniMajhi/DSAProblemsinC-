using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision
{
    internal class SubsetSequence
    {
        public String solve(string A)
        {
            char minChar1 = 'z';
            char minChar2 = 'z';
            int idx = 0;

            //loop till n-1: because we are considering first element
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] < minChar1)
                {
                    minChar1 = A[i];
                    idx = i;
                }
            }
            ///loop from idx+1 to n to find minChar2
            for (int i = idx + 1; i < A.Length; i++)
            {
                if (A[i] < minChar2)
                {
                    minChar2 = A[i];
                }
            }
            return minChar1 + minChar2.ToString();
        }
    }
}
