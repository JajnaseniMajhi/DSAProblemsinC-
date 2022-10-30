using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractice
{
    public class FIndSubset
    {
        // Function candidate has to implement
      public int SubsetNumber(List<int> A, int n)
        {

            int oddNoCount = 0;
            int evenNoCount = 0;
            for(int i=0;i<A.Count;i++)
            {
                if (A[i] % 2 == 0)
                {
                    evenNoCount = evenNoCount + 1;
                }
                else
                {
                    oddNoCount = oddNoCount + 1;
                }
            }
            if(oddNoCount==0)
            {
                return -1;
            }
            if(oddNoCount%2==0 )
            {
                return evenNoCount + oddNoCount - 1;
            }
            else
            {
                return (evenNoCount + oddNoCount);
            }
        }


        
}
}
