using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking
{
    public class Sixlets
    {
        public int Solve(List<int> A, int B)
        {
            List<int> temp = new List<int>();
            return GetSubSeq(A, temp, B, 0, 0);
        }

        public int GetSubSeq(List<int> A, List<int> help, int B, int sum, int index)
        {
            if (index == A.Count)
            {
                if (sum <= 1000 && help.Count == B)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            sum = sum + A[index];
            help.Add(A[index]);
            int leftCall = GetSubSeq(A, help, B, sum, index + 1);
            sum = sum - A[index];
            help.Remove(A[index]);
            int rightCall = GetSubSeq(A, help, B, sum, index + 1);
            return leftCall + rightCall;
        }
    }
}

    
