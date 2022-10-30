using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractice
{
    public class MaxMinDiff
    {
        
            public int solve(List<int> A)
            {
                var LMax = CreateLeftMaximumIndexArray(A);
                var RMax = CreateRightMaximumIndexArray(A);
                var LMin = CreateLeftMinimumIndexArray(A);
                var RMin = CreateRightMinimumIndexArray(A);
                long ans = 0;
                long mod = 1000000007;
                for (int i = 0; i < A.Count; i++)
                {
                    //subarray in which A[i] is min
                    int p1 = LMin[i];
                    int p2 = RMin[i];
                    long prodMin = ((long) (i - p1) * (p2 - i)) % mod;
                long minContribution = (prodMin * A[i]) % mod;

                //subarray in which A[i] is max
                int p3 = LMax[i];
                int p4 = RMax[i];
                long prodMax = ((long) (i - p3) * (p4 - i)) % mod;
                long maxContribution = (prodMax * A[i]) % mod;

                //computing ans
                ans = (ans % mod) + ((maxContribution - minContribution) % mod);
                ans = ans % mod;
            }
            if (ans< 0) {
              ans = (ans + mod) % mod;
            }
            return (int) (ans % mod);
                }


            // To calculate the max sum means contribution of element as maximum
            public List<int> CreateLeftMaximumIndexArray(List<int> A)
            {
                Stack<int> LMax = new Stack<int>();
                List<int> result = new List<int>();
                for (int i = 0; i < A.Count; i++)
                {
                    while (LMax.Count > 0 && A[LMax.Peek()] <= A[i])
                    {
                        LMax.Pop();
                    }
                    if (LMax.Count == 0)
                    {
                        result.Add(-1);
                    }
                    else
                    {
                        result.Add(LMax.Peek());
                    }
                    LMax.Push(i);
                }
                return result;
            }

            public List<int> CreateRightMaximumIndexArray(List<int> A)
            {
                Stack<int> stack = new Stack<int>();
                List<int> result = new List<int>();
                int size = A.Count;
                for (int i = 0; i < A.Count; i++)
                {
                    result.Add(size);
                }
                for (int i = A.Count - 1; i >= 0; i--)
                {
                    while (stack.Count > 0 && A[stack.Peek()] <= A[i])
                    {
                        stack.Pop();
                    }
                    if (stack.Count == 0)
                    {
                        result[i] = size;
                    }
                    else
                    {
                        result[i] = stack.Peek();
                    }
                    stack.Push(i);

                }
                return result;
            }

            //To calculate the mini sum as the element to be minimum in subarray
            public List<int> CreateLeftMinimumIndexArray(List<int> A)
            {
                Stack<int> stack = new Stack<int>();
                List<int> result = new List<int>();
                for (int i = 0; i < A.Count; i++)
                {
                    while (stack.Count > 0 && A[stack.Peek()] > A[i])
                    {
                        stack.Pop();
                    }
                    if (stack.Count == 0)
                    {
                        result.Add(-1);
                    }
                    else
                    {
                        result.Add(stack.Peek());
                    }
                    stack.Push(i);
                }
                return result;
            }

            public List<int> CreateRightMinimumIndexArray(List<int> A)
            {
                Stack<int> stack = new Stack<int>();
                List<int> result = new List<int>();
            int size = A.Count;
                for (int i = 0; i < A.Count; i++)
                {
                    result.Add(size);
                }
                for (int i = A.Count - 1; i >= 0; i--)
                {
                    while (stack.Count > 0 && A[stack.Peek()] >= A[i])
                    {
                        stack.Pop();
                    }
                    if (stack.Count == 0)
                    {
                        result[i] = size;
                    }
                    else
                    {
                        result[i] = stack.Peek();
                    }
                    stack.Push(i);
                }
                return result;
            }
        }

    }

