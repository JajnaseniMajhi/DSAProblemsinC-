using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision
{
    internal class MaxNonNegativeSubArray
    {
        int maxSum = int.MinValue;
        public List<int> Solve(List<int> A)
        {
            int sum = 0;
            int startIndex = -1;
            int endIndex = -1;
            int maxLength = 0;
            int length = 0;
            for(int i=0; i<A.Count; i++)
            {
                if (A[i]>=0)
                {
                    sum = sum + A[i];
                    endIndex = i;
                }
                else
                {
                    length = endIndex - startIndex; 
                   
                    if(maxSum<sum)
                    {
                        maxSum = sum;
                    }
                    if(maxSum==sum)
                    {

                    }
                    sum = 0;
                    startIndex = i+1;
                }

            }

            return null;
        }
    }
}
