using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision
{
    public class MaximumSumSubArray
    {
        public int MaximumSum(List<int> A)
        {
            int maxSum = int.MinValue;
            int sum = 0;

            for(int i=0; i<A.Count; i++)
            {
                sum = sum + A[i];
                maxSum = Math.Max(maxSum, sum);
                if (sum<0)
                {
                    sum = 0;
                }
            }

            return maxSum;
        }
    }
}
