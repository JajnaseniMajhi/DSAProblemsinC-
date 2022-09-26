using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPractice
{
    internal class FindPeakElement
    {
        public int FindPeakElemnt(List<int> A)
        {
            int l = 0;
            int r = A.Count - 1;


            while (l < r)
            {

                int mid = (l + r) / 2;


                if (A[mid + 1] > A[mid])
                    l = mid + 1;

                else
                    r = mid;
            }


            return A[l];
        }



        //1.Start two pointers from beginning & end
        //2. If (A[l] +A[r] == sum) then increment global "ans" variable 
        //3. To handle duplicates, count all duplicate values equal to A[r] and add it to global variable

        public int solve(List<int> A, int B)
        {
            int mod = 1000 * 1000 * 1000 + 7;
            int l = 0, r = A.Count - 1, ans = 0;
            while (l < r)
            {
                int sum = A[l] + A[r];
                if (sum == B)
                {
                    int count = 0, prev = r;
                    while (prev > l && A[r] == A[prev])
                    {//count duplicate values from right pointer
                        count++;
                        prev--;
                    }
                    ans = (ans + count) % mod;
                    l++;
                }
                else if (sum < B)
                {
                    l++;
                }
                else if (sum > B)
                {
                    r--;
                }
            }
            return ans;
        }

        public int solve_Dict(List<int> A, int B)
        {
            // long is recommended or else it will fail at submission
            Dictionary<int, long> freq = new Dictionary<int, long>();
            int L = 0, R = A.Count - 1, mod = 1000000007;
            long count = 0;
            // Calculating frequency// not recommended to use frequency array *see constraints*
            for (int i = 0; i < A.Count; i++)
            {
                if (freq.ContainsKey(A[i]))
                {
                    freq[A[i]]++;
                }
                else
                {
                    freq.Add(A[i], 1);
                }

            }
            while (L < R) // for loop can be used as well, i used two pointers:P 
            {
                if (A[L] + A[R] == B)
                {
                    if (A[L] == A[R])
                    {
                        long num = ((freq[A[L]] * (freq[A[L]] - 1)) / 2) % mod;// important point to note for duplicate numbers
                        count = (count + num) % mod;
                    }
                    else
                    {
                        long num = (freq[A[L]] * freq[A[R]]) % mod;
                        count = (count + num) % mod;
                    }
                    freq[A[L]] = 0; freq[A[R]] = 0;// if you won't do this you will get results*2, so in final answer it needs to divided by 2
                }
                if ((A[L] + A[R]) > B)
                {
                    R--;
                }
                else
                {
                    L++;
                }
            }
            return (int)count;
        }
    }
}

