using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public  class RegExMatch
    {
        public int iSrgeMatch(string A, string B)
        {
            int m = A.Length;
            int n = B.Length;

            bool[,] dp = new bool[m+1, n+1];
            for(int i=0; i<m+1;i++)
            {
                for(int j=0;j<n+1;j++)
                {
                    dp[i,j] = false;
                }
            }
            dp[0, 0] = true;
            int index = 1;
            while (index < n+1 && B[index - 1] == '*' )
            {
                dp[0, index] = dp[0, index - 2];
                index = index + 1;
            }

            for(int i=1;i<m+1; i++)
            {
                for(int j=1; j<n+1; j++)
                {
                    if ((A[i - 1] == B[j-1]) || B[j-1]=='?')
                    {
                        dp[i, j] = dp[i - 1,j-1];
                    }
                    else
                    {
                        if (B[j-1]=='*')
                        {
                            dp[i, j] = dp[i - 1, j] || dp[i, j - 1];
                        }
                        else
                        {
                            dp[i, j] = false;
                        }
                    }
                }
            }
            return dp[m, n] == true ? 1 : 0;
        }
    }
}
