using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class KnapsackProblem1
    {
        public int solve(List<int> A, List<int> B, int C)
        {
            int[,] dp = new int[A.Count + 1, C + 1];

            //for (int i = 0; i < A.Count + 1; i++)
            //{
            //    for (int j = 0; j < C + 1; j++)
            //    {
            //        dp[i, j] = 0;
            //    }
            //}
            

            for(int i=1; i<A.Count+1;i++)
            {
                for (int j = 0; j < C + 1; j++)
                {
                    int noPick = dp[i - 1, j];

                    if (j >= B[i-1])
                    {
                        dp[i, j] = Math.Max(noPick, dp[i - 1, j - B[i-1]] + A[i-1]);
                    }
                    else
                    {
                        dp[i, j] = noPick;
                    }
                }

            }

            return dp[A.Count, C];

        }

        public int solveOptimized(List<int> A, List<int> B, int C)
        {
            // Populate base cases
            int[] dp = new int[C + 1];
            for (int r = 0; r < C + 1; r++)
            {
                dp[r] = 0;
            }

            for (int item = 1; item <= A.Count; item++)
            {
                for (int w = C; w >= 1; w--)
                {
                    int noPIck = dp[w]; 
                                                           
                    int pick = 0; 

                    int weightOfCurr = B[item - 1]; 
                    if (w >= weightOfCurr)
                    { 
                        pick = A[item - 1]; 

                        int remainingCapacity = w - weightOfCurr; 
                        pick += dp[remainingCapacity]; 
                                                                  
                    }

                    dp[w] = Math.Max(noPIck, pick); 

                }
            }

            return dp[C];
    }
    }
}
