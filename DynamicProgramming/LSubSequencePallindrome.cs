using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class LSubSequencePallindrome
    {
        public int solve(string A)
        {
            var B = new string(A.ToCharArray().Reverse().ToArray());
            int n = A.Length;

            int[,] dp = new int[n+1, n+1];
            for (int i=0; i<n+1;i++)
            {
                for(int j=0; j<n+1;j++)
                {
                    dp[i, j] = 0;
                }
            }

            for(int i=1; i<n+1;i++)
            {
                for (int j=1; j<n+1; j++)
                {
                    if (A[i - 1] == B[j-1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }


            return dp[n,n];
        }
    }
}
