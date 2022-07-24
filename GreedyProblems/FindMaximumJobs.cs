using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyProblems
{
    public class FindMaximumJobs
    {
        public int Solve(List<int> A, List<int> B)
        {
            List<KeyValuePair<int, int>> mapping = new List<KeyValuePair<int, int>>();

            for (int i=0;i<A.Count;i++)
            {
                mapping.Add(new KeyValuePair<int, int>(A[i], B[i]));
            }

            mapping.Sort((x, y) => x.Value.CompareTo(y.Value));
            int count = 0;
            int endTime = int.MinValue;
            for(int i=0;i<A.Count;i++)
            {
                if (mapping[i].Key >=endTime)
                {
                    count = count + 1;
                    endTime = mapping[i].Value;
                }
            }

            Console.WriteLine(count);
            foreach(var x in mapping)
            {
                Console.Write(x.Key + " ");
                Console.Write(x.Value);
                Console.WriteLine();
            }

            return 0;
        }
    }
}
