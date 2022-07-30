using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking
{
    public  class AllCombinations
    {
        List<List<int>> result = new List<List<int>>();
        public List<List<int>> permute(List<int> A)
        {
            GetPermutaion(new List<int>() { 1, 2, 3 },0);
            return result;

        }

        public void  GetPermutaion(List<int> A, int index)
        {
            if(index==A.Count)
            {
                result.Add(A);
            }
            for(int i = index; i < A.Count; i++)
            {
                int temp = A[i];
                A[i] = A[index];
                A[index] = temp;
                GetPermutaion(A, index + 1);
                temp = A[i];
                A[i] = A[index];
                A[index] = temp;
            }
        }
    }

}
