using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractice
{
    public class NearestSmallestElement
    {
        public List<int> LeftSmallestElement(List<int> A)
        {
            Stack<int> stack = new Stack<int>();
            List<int> result = new List<int>();
            for(int i=0;i<A.Count;i++)
            {
                while(stack.Count > 0 && stack.Peek() >= A[i])
                {
                    stack.Pop();
                }

                if(stack.Count ==0)
                {
                    result.Add(-1);
                }
                else
                {
                    result.Add(stack.Peek());
                }
                stack.Push(A[i]);
            }

            return result;
        }
    }
}
