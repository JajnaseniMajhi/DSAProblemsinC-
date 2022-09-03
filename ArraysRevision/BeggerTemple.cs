using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision
{
    public class BeggerTemple
    {
        public List<int> solve(int A, List<List<int>> B)
        {
            List<int> result = new List<int>();
            for(int i=0; i< A; i++)
            {
                result.Add(0);
            }
            int s = -1;
            int e = -1;
            int p = 0;

            for (int i=0; i<B.Count; i++)
            {
                s = B[i][0];
                e = B[i][1];
                p = B[i][2];
                result[s - 1] = result[s - 1] + p;
                if(e!=A)
                result[e] = result[e] - p;
            }

            for(int i=1; i<A;i++)
            {
                result[i] = result[i - 1] + result[i];
            }

            return result;
        }
    }
}
