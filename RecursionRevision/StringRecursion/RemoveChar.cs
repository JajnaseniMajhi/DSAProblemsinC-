using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionRevision.StringRecursion
{
    public class RemoveChar
    {
        public void  Solve(string input,int index, StringBuilder output)
        {
            if(index==input.Length)
            {
                Console.Write(output);
                return;
            }

            if (input[index]!='a')
            {
                output.Append(input[index]);
            }

            Solve(input,index+1,output);
        }
    }
}
