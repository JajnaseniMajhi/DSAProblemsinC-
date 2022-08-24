using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class DungeonPrincess
    {
        public int CalculateMinimumHP(List<List<int>> A)
        {
            List<List<int>> dp = new List<List<int>>();

            int rows = A.Count;
            int cols = A[0].Count;
            for (int i = 0; i<rows+1; i++)
            {
                dp.Add(new List<int>());
                for (int j = 0; j < cols+1; j++)
                {
                    dp[i].Add(int.MaxValue);
                }
            }

            dp[rows][cols - 1] = 1;
            dp[rows - 1][cols] = 1;

            for (int i=rows-1; i>=0; i--)
            {
                for(int j= cols-1;j>=0;j--)
                {
                    int currHealth = Math.Min(dp[i][j + 1], dp[i + 1][j]) - A[i][j];
                    if (currHealth<=0)
                    {
                        dp[i][j] = 1;
                    }
                    else
                    {
                        dp[i][j] = currHealth;
                    }
                }
            }

            return dp[0][0];
        }
    }
}
