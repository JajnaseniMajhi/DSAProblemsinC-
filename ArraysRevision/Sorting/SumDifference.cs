using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision.Sorting
{
    public class SumDifference
    {
        public int FindMaxMinDiffSUbSequence(List<int> A)
        {
             A.Sort();
            int result = 0;
            int min = 0; int max = 0;
            int mod = 1000000007;

            for (int i=0; i<A.Count;i++)
            {
                min = min * 2;
                min = (min + A[i]) % mod;

            }
            for (int i = A.Count-1; i>=0; i--)
            {
                max = max * 2;
                max = (max + A[i]) % mod;

            }

            return (max-min+mod)%mod;

        }
    }
}
