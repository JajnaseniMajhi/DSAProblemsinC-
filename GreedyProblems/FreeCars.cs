using Heaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyProblems
{
    public class FreeCars
    {
        public int Solve(List<int> A, List<int> B)
        {
            List<KeyValuePair<int,int>> mapping = new List<KeyValuePair<int, int>>();
            int ans = 0;
            for(int i=0;i<A.Count; i++)
            {
                KeyValuePair<int, int> pair = new KeyValuePair<int, int>(A[i], B[i]);
                mapping.Add(pair);
            }
            int mod = 1000000007;
            mapping.Sort((x,y)=>x.Key.CompareTo(y.Key));
            int day = 0;
            Heap heap = new Heap(0);
            for(int i=0;i<A.Count;i++)
            {
                if (day < mapping[i].Key)
                {
                    day = day + 1;
                    heap.InserttoMinHeap(mapping[i].Value);
                    ans = (ans % mod + mapping[i].Value % mod) % mod;
                }
                else
                {
                    int min = heap.getMinimumFromMinHeap();
                    if (mapping[i].Value > min)
                    {
                        ans = (ans % mod - min % mod) % mod;
                        heap.InserttoMinHeap(mapping[i].Value);
                        ans = (ans % mod + mapping[i].Value % mod) % mod;
                    }
                    else
                    {
                        heap.InserttoMinHeap(min);
                    }
                }
               
            }

            Console.WriteLine(ans);

            //foreach(var key in mapping)
            //{
            //    Console.WriteLine(key.Key);
            //}

            return (int) ans;

        }
    }
}
