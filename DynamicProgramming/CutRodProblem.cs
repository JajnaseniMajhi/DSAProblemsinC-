using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class CutRodProblem
    {
        public int cutRods(List<int> A)
        {
            int[] dp = new int[A.Count + 1];
            dp[0] = 0;
             for(int i=1; i<A.Count+1; i++ )
            {
                int maxValue = int.MinValue;
                for(int j=0;j<i; j++ )
                {
                    maxValue = Math.Max(maxValue, dp[i - j-1] + A[j]);
                }
                dp[i] = maxValue;
            }

            return dp[A.Count];

        }

    }
}
