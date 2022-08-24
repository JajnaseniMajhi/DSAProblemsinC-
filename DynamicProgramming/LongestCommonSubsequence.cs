using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class LongestCommonSubsequence
    {
        public int LCS(string s1, string s2,int i, int j, int[,] dp)
        {
            if(i<0 || j<0)
            {
                return 0;
            }
            if(dp[i,j] != -1)
            {
                return dp[i,j];
            }
            if (s1[i] == s2[j])
            {
                dp[i,j] = 1 + LCS(s1, s2, i - 1, j - 1, dp);
            }
            else
            {
                dp[i,j] = Math.Max(LCS(s1, s2, i - 1, j, dp), LCS(s1, s2, i, j - 1, dp));
            }
            return dp[i,j];
        }

        public int IterativeLCS(string A, string B)
        {
            int m = A.Length;
            int n = B.Length;
            int[,] dp = new int[m+1,n+1];
            for(int i=0;i<m+1;i++)
            {
                for(int j=0;j<n+1;j++)
                {
                    dp[i, j] = 0;
                }
            }

            for(int i=1; i<m+1;i++)
            {
                for(int j=1; j<n+1;j++)
                {
                    if (A[i-1] == B[j-1])
                    {
                        dp[i, j] = dp[i - 1, j-1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);

                    }
                }
            }

            return dp[m,n];
        }
        public int Solve(string A, string B)
        {
            int[,] dp = new int[A.Length,B.Length];

            for(int i=0;i<A.Length;i++)
            {
                for(int j=0;j<B.Length;j++)
                {
                    dp[i, j] = -1;
                }
            }
            
            return LCS(A, B, A.Length-1, B.Length-1, dp);
        }
    }
}
