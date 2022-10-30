using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapRevision
{
    //    Given N bags, each bag contains Bi chocolates.There is a kid and a magician.
    //In a unit of time, the kid can choose any bag i, and eat Bi chocolates from it, then the magician will fill the ith bag with floor(Bi/2) chocolates.

    //Find the maximum number of chocolates that the kid can eat in A units of time.

    //NOTE:

    //floor() function returns the largest integer less than or equal to a given number.
    //Return your answer modulo 109+7

    // Input 1:

    // A = 3
    // B = [6, 5]
    //Input 2:

    // A = 5
    // b = [2, 4, 6, 8, 10]


    //    Example Output
    //Output 1:

    // 14
    //Output 2:

    // 33
    public class MaxChocolates
    {

        public int maxChoco(int A, List<int> B)
        {
            PriorityQueue<int, int> choP = new PriorityQueue<int, int>(new MaxHeapComparer());
            for (int i = 0; i < B.Count; i++)
            {
                choP.Enqueue(B[i], B[i]);
            }
            long mod = 1000000007;
            long totalResult = 0;
            for(int i=1; i<=3;i++)
            {
                int topBag = choP.Dequeue();
                totalResult = ((long)(topBag % mod + totalResult % mod)) % mod;
                choP.Enqueue(topBag / 2, topBag/2);
            }


            return (int)totalResult;
        }


       
    }

    public class MaxHeapComparer: IComparer<int>
    {
        public int Compare(object? x, object y)
        {
           if(x==null)
            {
                return 1;
            }

            int value1 = (int)x;
            int value2 = (int)y;
            if(value1>value2)
            {
                return -1;
            }

            if(value1<value2)
            {
                return 1;
            }

            return 0;
        }

        public int Compare(int value1, int value2)
        {
            //int value1 = (int)x;
            //int value2 = (int)y;
            if (value1 > value2)
            {
                return -1;
            }

            if (value1 < value2)
            {
                return 1;
            }

            return 0;
        }
    }
}
