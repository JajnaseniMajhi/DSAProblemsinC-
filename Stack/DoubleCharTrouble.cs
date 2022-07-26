using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class DoubleCharTrouble
    {
        public string Solve(string A)
        {
            List<char> tempStack = new List<char>();
            tempStack.Add(A[0]);

            for(int i=1;i<A.Length;i++)
            {
                if (tempStack.Count> 0 && tempStack[tempStack.Count-1]==A[i])
                {
                    tempStack.RemoveAt(tempStack.Count-1);
                }
                else
                {
                    tempStack.Add(A[i]);
                }
            }
            string result = string.Empty;
            for(int i=0;i<tempStack.Count;i++)
            {
                result= result+ tempStack[i];
            }
            return result;
        }
    }
}
