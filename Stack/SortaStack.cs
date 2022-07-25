using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    //Sort stack using another stack
    public class SortaStack
    {
        public List<int> Solve(List<int> A)
        {
            List<int> tempStack = new List<int>();
            int size = A.Count;
            int topElement = A[A.Count - 1];
            A.RemoveAt(A.Count - 1);
            tempStack.Add(topElement);
            while (A.Count > 0)
            {
                topElement = A[A.Count-1];
                A.RemoveAt(A.Count - 1);
               
                    while(tempStack.Count>0 && topElement < tempStack[tempStack.Count - 1])
                    {
                            int removedE= tempStack[tempStack.Count-1];
                            tempStack.RemoveAt(tempStack.Count-1);
                            A.Add(removedE);
                    }
                    tempStack.Add(topElement);

            }

            return tempStack;
        }
    }
}
