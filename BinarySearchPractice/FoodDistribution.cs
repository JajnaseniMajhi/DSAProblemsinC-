using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPractice
{
    //The government wants to set up B distribution offices across N cities for the distribution of food
    //packets.The population of the ith city is A[i]. Each city must have at least 1 office, and people can go to an office of their own city.
    //We want to maximize the minimum number of people who can get food in any single office.
    internal class FoodDistribution
    {
        public int Solve(List<int> A, int B)
        {
            int min = int.MaxValue;
            int sum = 0;

            for (int i=0; i<A.Count; i++)
            {
                min = Math.Min(min, A[i]);
                sum = sum + A[i];
            }
            if(sum<B)
            {
                return 0;
            }
            int ans = 0;
            int l = 1;
            int r = min;
            while(l<=r)
            {
                int mid = (l + r) / 2;
                if(Check(mid,A,B))
                {
                    ans = mid;
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }

            }

            return ans;
        }

        private bool Check(int mid, List<int> A, int B)
        {
            int req = 0;
            for(int i=0; i<A.Count;i++)
            {
                req= req+ A[i]/mid;
            }
            return req >= B;
        }
    }
}
