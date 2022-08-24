using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class EditDistance
    {
        public int minDistance(string A, string B)
        {
            int[,] dp = new int[A.Length, B.Length];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    dp[i, j] = -1;
                }
            }

            return Ed(A, B, A.Length - 1, B.Length - 1, dp);

        }
        public int Ed(string s1, string s2,int i, int j, int[,] dp)
        {
            if(i==-1 && j==-1)
            {
                return 0;
            }
            if(i==-1)
            {
                return j + 1;
            }
            if(j==-1)
            {
                return i + 1;
            }

            if (dp[i,j]!=-1)
            {
                return dp[i, j];
            }

            if (s1[i] == s2[j])
            {
                dp[i, j] = Ed(s1, s2, i - 1, j - 1, dp);
            }
            else
            {
                dp[i, j] = 1+ Math.Min(Math.Min(Ed(s1, s2, i, j - 1, dp), Ed(s1, s2, i - 1, j - 1, dp)), Ed(s1, s2, i - 1, j,dp));
            }

            return dp[i, j];
        }
    }
}
