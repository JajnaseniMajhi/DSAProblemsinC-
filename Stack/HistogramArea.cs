using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractice
{
    public class HistogramArea
    {
        public int largestRectangleArea(int[] A)
        {
            int n = A.Length;
            if (n == 1) return A[0];

            int[] SL = new int[n];
            int[] SR = new int[n];

            SL = smallerToLeft(A, SL);
            SR = smallerToRight(A, SR);

            int largeArea = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int area = A[i] * (SR[i] - SL[i] - 1);
                largeArea = Math.Max(largeArea, area);
            }
            return largeArea;
        }
        public int[] smallerToLeft(int[] A, int[] SL)
        {

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < A.Length; i++)
            {
                while (stack.Count>0 && A[stack.Peek()] >= A[i])
                {
                    stack.Pop();
                }
                if (stack.Count==0)
                {
                    SL[i] = -1;
                }
                else
                {
                    SL[i] = stack.Peek();
                }
                stack.Push(i);
            }
            return SL;

        }

        public int[] smallerToRight(int[] A, int[] SL)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = A.Length - 1; i >= 0; i--)
            {
                while (stack.Count>0 && A[stack.Peek()] >= A[i])
                {
                    stack.Pop();
                }
                if (stack.Count==0)
                {
                    SL[i] = A.Length;
                }
                else
                {
                    SL[i] = stack.Peek();
                }
                stack.Push(i);
            }
            return SL;
        }
        public  int largestRectangleArea1(int[] height)
        {
            if (height == null || height.Length == 0)
            {
                return 0;
            }
            int[] lessFromLeft = new int[height.Length]; // idx of the first bar the left that is lower than current
            int[] lessFromRight = new int[height.Length]; // idx of the first bar the right that is lower than current
            lessFromRight[height.Length - 1] = height.Length;
            lessFromLeft[0] = -1;

            for (int i = 1; i < height.Length; i++)
            {
                int p = i - 1;

                while (p >= 0 && height[p] >= height[i])
                {
                    p = lessFromLeft[p];
                }
                lessFromLeft[i] = p;
            }

            for (int i = height.Length - 2; i >= 0; i--)
            {
                int p = i + 1;

                while (p < height.Length && height[p] >= height[i])
                {
                    p = lessFromRight[p];
                }
                lessFromRight[i] = p;
            }

            int maxArea = 0;
            for (int i = 0; i < height.Length; i++)
            {
                maxArea = Math.Max(maxArea, height[i] * (lessFromRight[i] - lessFromLeft[i] - 1));
            }

            return maxArea;
        }

        public int largestRectangleAreaOwn(List<int> A)
        {
            //left small
            //Right small
            //Calculate area for eact element
            var LSI = GetLeftSmall(A);
            var RSI = GetRightSmall(A);
            int size = A.Count;
            int result = int.MinValue;
            if (size == 1)
            {
                return A[0];
            }
            for (int i = 0; i < size; i++)
            {
                int width = RSI[i] - LSI[i] - 1;
                result = Math.Max(A[i] * width, result);
            }
            return result;
        }

        public List<int> GetLeftSmall(List<int> A)
        {
            Stack<int> stack = new Stack<int>();
            List<int> result = new List<int>();
            for(int i=0; i<A.Count;i++)
            {
                result.Add(-1);
            }
            for (int i = 0; i < A.Count; i++)
            {
                while (stack.Count > 0 && A[i] <= A[stack.Peek()])
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    result[i] = -1;
                }
                else
                {
                    result[i]=stack.Peek();
                }

                stack.Push(i);
            }

            return result;
        }


        public List<int> GetRightSmall(List<int> A)
        {
            Stack<int> stack = new Stack<int>();
            List<int> result = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                result.Add(-1);
            }
            for (int i = A.Count - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && A[i] <= A[stack.Peek()])
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    result[i] = A.Count;
                }
                else
                {
                    result[i]= stack.Peek();
                }

                stack.Push(i);
            }
            return result;
        }
    }
}
