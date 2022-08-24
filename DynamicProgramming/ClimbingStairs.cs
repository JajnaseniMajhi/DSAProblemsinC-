using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class ClimbingStairs
    {
        public int Iterative(int number)
        {
            int[] dp = new int[number+1];
            if(number<=1)
            {
                return number;
            }
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i < number+1; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[number];
        }
    }
}
