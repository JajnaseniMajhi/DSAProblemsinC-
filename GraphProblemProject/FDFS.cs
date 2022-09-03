using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblemProject
{

// You are given N towns(1 to N). All towns are connected via unique directed path as mentioned in the input.
//Given 2 towns find whether you can reach the first town from the second without repeating any edge.
//B C : query to find whether B is reachable from C.
//Input contains an integer array A of size N and 2 integers B and C ( 1 <= B, C <= N ).
//There exist a directed edge from A[i] to i+1 for every 1 <= i<N.Also, it's guaranteed that A[i] <= i for every 1 <= i < N.
//NOTE: Array A is 0-indexed.A[0] = 1 which you can ignore as it doesn't represent any edge.
    public class FDFS
    {
        public int solve(List<int> A, int B, int C)
        {

            //Step-1 make the list mapping of Graph
            List<List<int>> graph = new List<List<int>>();

            for (int i=0; i<A.Count+1; i++)
            {
                graph.Add(new List<int>());
            }

            for(int i=0; i<A.Count;i++)
            {
                graph[A[i]].Add(i + 1);
            }

            bool[] visited = new bool[A.Count + 1];

            Stack<int> graphStack = new Stack<int>();
            graphStack.Push(C);
            while(graphStack.Count>0)
            {
                int currNode = graphStack.Pop();
                visited[currNode] = true;
                if(currNode<graph.Count)
                {
                    for (int j = 0; j < graph[currNode].Count; j++)
                    {
                        if (!visited[graph[currNode][j]])
                        {
                            graphStack.Push(graph[currNode][j]);
                        }
                    }
                }
                
            }

            return visited[B] ? 1 : 0;
        }
    }
}
