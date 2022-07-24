using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyProblems
{
    public  class MiceToHolesProblem
    {
        public int Solve(List<int> A, List<int>B)
        {
            A.Sort();
            B.Sort();
            int maxDiff = int.MinValue;

            for (int i=0;i<A.Count; i++)
            {
                int diff = Math.Abs(A[i] - B[i]);
                maxDiff = Math.Max(diff, maxDiff);
            }
            return maxDiff;
        }
    }
}
