using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class MinimumPathSum
    {
        public int minPathSum(List<List<int>> A)
        {
            int[,] dp = new int[A.Count, A[0].Count];

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A[0].Count; j++)
                {
                    dp[i, j] = -1;
                }
            }
            return GetPathSumDp(A.Count - 1, A[0].Count - 1, dp,A);
        }

        public int GetPathSumDp(int i, int j, int[,] dp, List<List<int>> A)
        {
            if(i<0 || j<0)
            {
                return int.MaxValue;
            }

            if(i==0 && j==0)
            {
                return A[0][0];
            }

            if (dp[i,j]!=-1)
            {
                return dp[i,j];
            }

            dp[i,j] = A[i][j] + Math.Min(GetPathSumDp(i, j-1, dp, A), GetPathSumDp(i-1, j, dp, A));
            return dp[i,j];
        }
    }
}
