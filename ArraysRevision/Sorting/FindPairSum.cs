using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision.Sorting
{
    public  class FindPairSum
    {
        public int FindPairs(List<int> A, int B)
        {
            A.Sort();
            int p1 = 0;
            int p2 = A.Count - 1;
            int count = 0;
            while(p1<p2)
            {
                if (A[p1] + A[p2]==B)
                {
                    count=count+1;
                    p1 = p1 + 1;
                }

                else if(A[p1] + A[p2]<B)
                {
                    p1 = p1 + 1; ;
                }
                else
                {
                    count++;
                    p2 = p2 - 1;
                }
            }

            return count;
        }
    }
}
