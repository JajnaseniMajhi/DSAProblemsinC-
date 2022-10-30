using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractice
{
    public class MaxMinUsingStack
    {
        public int solve(int[] A)
        {
            //pre-compute all of this
            int[] prevSmall = prevSmallerIndex(A);
            int[] nextSmall = nextSmallerIndex(A);
            int[] prevGreater = prevGreaterIndex(A);
            int[] nextGreater = nextGreaterIndex(A);
            int mod = 1000 * 1000 * 1000 + 7;

            long ans = 0;
            for (int i = 0; i < A.Length; i++)
            {
                //subarray in which A[i] is min
                int p1 = prevSmall[i];
                int p2 = nextSmall[i];
                long prodMin = ((long) (i - p1) * (p2 - i)) % mod;
            long minContribution = (prodMin * A[i]) % mod;

            //subarray in which A[i] is max
            int p3 = prevGreater[i];
            int p4 = nextGreater[i];
            long prodMax = ((long)(i - p3) * (p4 - i)) % mod;
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

private static int[] prevSmallerIndex(int[] A)
{
    int N = A.Length;
    int[] ans = new int[N];
    //Arrays.fill(ans, -1);
    Stack<int> stack = new Stack<int>();
            for(int i=0;i<N;i++)
            {
                ans[i] = -1;

            }

    for (int i = 0; i < N; i++)
    {
        while (stack.Count>0 && A[i] <= A[stack.Peek()])
        {
            stack.Pop();
        }
        if (stack.Count>0)
        {
            ans[i] = stack.Peek();
        }
        stack.Push(i);
    }
    return ans;
}

private static int[] nextSmallerIndex(int[] A)
{
    int N = A.Length;
    int[] ans = new int[N];
    //Arrays.fill(ans, N); //edge case
    for(int i=0;i<N;i++)
            {
                ans[i] = N;
            }
    Stack<int> stack = new Stack<int>();

    for (int i = N - 1; i >= 0; i--)
    {
        while (stack.Count>0 && A[i] <= A[stack.Peek()])
        {
            stack.Pop();
        }
        if (stack.Count>0)
        {
            ans[i] = stack.Peek();
        }
        stack.Push(i);
    }
    return ans;
}

private static int[] prevGreaterIndex(int[] A)
{
    int N = A.Length;
    int[] ans = new int[N];
            //Arrays.fill(ans, -1);
            for (int i = 0; i < N; i++)
            {
                ans[i] = -1;
            }
            Stack<int> stack = new Stack<int>();

    for (int i = 0; i < N; i++)
    {
        while (stack.Count>0 && A[i] >= A[stack.Peek()])
        {
            stack.Pop();
        }
        if (stack.Count>0)
        {
            ans[i] = stack.Peek();
        }
        stack.Push(i);
    }
    return ans;
}

private static int[] nextGreaterIndex(int[] A)
{
    int N = A.Length;
    int[] ans = new int[N];
            // Arrays.fill(ans, N); //edge case
            for (int i = 0; i < N; i++)
            {
                ans[i] = N;
            }
            Stack<int> stack = new Stack<int>();

    for (int i = N - 1; i >= 0; i--)
    {
        while (stack.Count>0 && A[i] >= A[stack.Peek()])
        {
            stack.Pop();
        }
        if (stack.Count>0)
        {
            ans[i] = stack.Peek();
        }
        stack.Push(i);
    }
    return ans;
}
    }
}
