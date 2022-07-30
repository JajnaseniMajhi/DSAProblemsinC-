using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionRevision.PatternSort
{
    public class PatternProblems
    {
        public void PrintPattern(int n)
        {
            if(n==0)
            {
                return;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            PrintPattern(n - 1);
        }

    }
}
