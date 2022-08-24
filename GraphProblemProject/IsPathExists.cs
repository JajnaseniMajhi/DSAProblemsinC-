using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblemProject
{
    public class IsPathExists
    {
        public int IsPathThere(int A, List<List<int>> B)
        {
            List<List<int>> graph = new List<List<int>>(A+1);

            for(int i=0; i<=A;i++)
            {
                graph.Add(new List<int>());
            }
            for(int i=0; i<B.Count;i++)
            {
                graph[B[i][0]].Add(B[i][1]);
            }

            bool[] visited = new bool[A + 1];

            for(int i =0; i<graph.Count;i++)
            {
                for(int j=0; j<graph[i].Count;j++)
                {
                    visited[graph[i][j]] = true;
                }
            }

            if (visited[A]==false)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        
    }
}
