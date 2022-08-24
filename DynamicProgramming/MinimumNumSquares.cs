using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public  class MinimumNumSquares
    {
        public int GetMinimumSquaresRequired(int A)
        {
            if (A <= 3)
                return A;
            
            int[] dp = new int[A + 1];

            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 3;
            
            for (int i = 4; i <= A; i++)
            {
                dp[i] = i;
                for (int x = 1; x <= Math.Ceiling(
                                  Math.Sqrt(i)); x++)
                {
                    int temp = x * x;
                    if (temp > i)
                        break;
                    else
                        dp[i] = Math.Min(dp[i], 1 +
                                        dp[i - temp]);
                }
            }

            int res = dp[A];

            return res;

        }
    }
}
