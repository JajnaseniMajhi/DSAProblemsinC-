using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision
{
    public class PickFromBothSides
    {
        public int solve(List<int> A, int B)
        {
            int e = A.Count-1;
            int size = A.Count;
            List<int> frontA= new List<int>();
            List<int> backA = new List<int>();
            
            for(int i=0; i<B;i++)
            {
                frontA.Add(0);
                backA.Add(0);
            }
            frontA[0]=A[0];
            backA[0]=A[e];
            for (int i=1; i<B; i++)
            {
                frontA[i] = frontA[i - 1] + A[i];
               
            }

            for(int i=1;i<B;i++)
            {
                backA[i] = backA[i-1] + A[e-i];
            }

            int maxSum = Math.Max(frontA[B-1], backA[B-1]);

            for( int i=1; i<B; i++)
            {
                maxSum = Math.Max(maxSum,frontA[i-1]+backA[B-i-1]);
            }

            return maxSum;
        }
    }
}
