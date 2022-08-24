using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class LetsParty
    {
        public int FindTotalOptions(int A)
        {
            int mod = 10003;
            int[] dp = new int[A + 1];
            if(A<=2)
            {
                return A;
            }
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;
            for(int i=2; i<A+1;i++)
            {
                dp[i]= dp[i-1] % mod+(( (i-1) %mod ) * dp[i-2] %mod);
                dp[i] = dp[i] % mod;
            }

            return dp[A];
                
        }
    }
}
