using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class UniquePath
    {
        public int uniquePathsWithObstacles(List<List<int>> A)
        {
            int[,] dp = new int[A.Count, A[0].Count];

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A[0].Count; j++)
                {
                    dp[i, j] = -1;
                }
            }
            return GetUniquePath(A.Count-1, A[0].Count-1,A, dp);
        }

        public int GetUniquePath(int i, int j,List<List<int>> A, int[,] dp)
        {
            if( i<0 || j<0)
            {
                return 0;
            }
            if (A[0][0] == 1)
            {
                return 0;
            }

            if (A[i][j]==1)
            {
                return 0;
            }

            if(i==0 && j==0)
            {
                return 1;
            }
            if (dp[i,j]!=-1)
            {
                return dp[i, j];
            }
            
           dp[i, j] = GetUniquePath(i, j - 1, A, dp) + GetUniquePath(i - 1, j, A, dp);
            
            return dp[i, j];
        }
    }
}
