using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyProblems
{
    public class Seats
    {
        public int Solve(string A)
        { 
            List<int> positions = new List<int>();
            for (int i=0;i<A.Length;i++)
            {
                if (A[i]=='x')
                {
                    positions.Add(i);
                }
            }
            long mod = 10000003;
            int middlePos = positions.Count / 2;
            int p = 1;
            long result = 0;
            //Swap left
            for (int i=0;i<middlePos;i++)
            {
                result= (result+ positions[middlePos] - positions[i]-p)% mod;
                p = p + 1;
            }
            //Swap right
            p = 1;
            for (int i = middlePos+1; i < positions.Count; i++)
            {
                result = (result + positions[i] - (positions[middlePos] +p)) % mod;
                p = p + 1;
            }

            return (int)(result % mod); 
        }
    }
}

