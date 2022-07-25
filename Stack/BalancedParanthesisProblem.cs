using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class BalancedParanthesisProblem
    { 
    
        public int Solve(string A)
    {
            List<char> charStack = new List<char>();
            char[] inputList = A.ToCharArray();
            charStack.Add(A[0]);
            for(int i=1;i<inputList.Length;i++)
            {
                bool flag = false;
                if (charStack.Count > 0)
                {
                    char topElement = charStack[charStack.Count - 1];
                    switch (inputList[i])
                    {
                        case '}':
                            if (topElement == '{')
                            {
                                charStack.RemoveAt(charStack.Count - 1);
                                flag = true;
                            }
                            break;
                       
                        case ']':
                            if (topElement == '[')
                            {
                                charStack.RemoveAt(charStack.Count - 1);
                                flag = true;
                            }
                            break;
                        case ')':
                            if (topElement == '(')
                            {
                                charStack.RemoveAt(charStack.Count - 1);
                                flag = true;
                            }
                            break;
                    }
                    if(flag==false)
                    {
                        charStack.Add(inputList[i]);
                    }

                }
                else
                {
                    charStack.Add(inputList[i]);
                }
                
            }

            if(charStack.Count==0)
            {
                return 1;
            }

            return 0;
    }
    }
}
