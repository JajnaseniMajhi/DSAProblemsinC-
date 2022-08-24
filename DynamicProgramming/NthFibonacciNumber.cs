using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class NthFibonacciNumber
    {
        public int[] dp;

        public NthFibonacciNumber(int number)
        {
           dp= new int[number+1];
           for(int i=0;i<number+1; i++)
            {
                dp[i] = -1;
            }
        }
            
    public int RecursionFib(int number)
        {
            if(number<=1)
            {
                return number;
            }

            return RecursionFib(number - 2) + RecursionFib(number - 1);
        }

        public int Dp1(int number)
        {
            if(number<=1)
            {
                dp[number]=number;
                return number;
            }

            if (dp[number]==-1)
            {
                dp[number]= Dp1(number - 1) + Dp1(number - 2);
                return dp[number];
            }
            return dp[number];
        }

        public int Iterative(int number)
        { 
           int[]  dp= new int[number + 1];
            dp[0] = 0;
            dp[1] = 1;
            for(int i=2;i<number+1; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[number];
        }

        public int IterativeSpaceC(int number)
        {
            int prevF = 0;
            int prevS = 1;
            int curr = -1;
            for (int i = 2; i < number + 1; i++)
            {
                curr = prevF + prevS;
                prevF = prevS;
                prevS = curr;
            }

            return curr;
        }
    }
}
