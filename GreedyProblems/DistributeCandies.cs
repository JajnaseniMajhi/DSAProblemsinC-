using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyProblems
{
    public class DistributeCandies
    {
        public int Solve(List<int> A)

        {
            int size = A.Count;
            List<int> result = Enumerable.Repeat(1, size).ToList();
            for(int i=1;i<size; i++)
            {
                if (A[i] > A[i-1])
                {
                    result[i]=result[i-1] + 1;
                }
            }
            int sum = 0;
            for(int i= size-2; i>=0;i--)
            {
                if (A[i] > A[i+1])
                {
                    result[i]=Math.Max(result[i],result[i+1] + 1);
                }
            }

            for(int i=0;i<size;i++)
            {
                sum = sum + result[i];
            }
            return sum; 
        }
    }
}



