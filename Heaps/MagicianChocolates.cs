using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class MagicianChocolates
    {
        public int nchoc(int A, List<int> B)
        {
            Heap maxHeap = new Heap(0);
            long total = 0;
            maxHeap.CreateMaxHeap(B);
            long m = 1000000007;
            for (int i=0;i<A;i++)
            {
                int maxChoc = maxHeap.getMaximumfromMaxHeap();
                maxHeap.InserttoMaxHeap(maxChoc / 2);
                total = (maxChoc % m + total % m) % m;
            }
            return(int) total;
        }
    }
}
