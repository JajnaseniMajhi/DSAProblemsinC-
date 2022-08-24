using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class NumberOfDecodes
    {
        public int numDecoding(string A)
        {
            if (A[0] == '0')
            {
                return 0;
            }
            long mod = 1000000007;
            int n = A.Length;
            if(A=="0")
            {
                return 0;
            }
            List<long> dp = new List<long>();
            for(int i=0; i<n+1;i++)
            {
                dp.Add(0);
            }
            dp[0] = 1;
            dp[1] = 1;

            for(int i=2; i<n+1;i++)
            {
                int oneCode = int.Parse(A.Substring(i - 1, 1));
                int twoCode = int.Parse(A.Substring(i - 2, 2));
                if (oneCode >= 1) dp[i] = (dp[i] % mod + dp[i - 1] % mod) % mod;
                if (twoCode >= 10 && twoCode <= 26) dp[i] = (dp[i] % mod + dp[i - 2] % mod) % mod;
            }
            return (int) (dp[n] % mod);
        }
    }
}
