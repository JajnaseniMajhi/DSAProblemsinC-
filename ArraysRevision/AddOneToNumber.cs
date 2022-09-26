using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision
{
    public  class AddOneToNumber
    {
        public List<int> AddOne(List<int> A)
        {
            int n = A.Count;
            if (n == 1 && A[0] == 0)
            {
                A[0] = 1;
                return A;
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] != 0)
                {
                    break;
                }
                else
                {
                    count = count + 1;

                }

            }
            for (int i = n - 1; i >= count; i--)
            {
                if (A[i] < 9)
                {
                    A[i] = A[i] + 1;
                    break;
                }
                else
                {
                    A[i] = 0;
                }
            }
            List<int> result = new List<int>();
            if (A[count]==0)
            {
                result.Add(1);
            }
            for (int i = count; i < n; i++)
            {
                result.Add(A[i]);
            }

           // result = new List<int>();
            //if (result[0] == 0)
            //{
            //    result.Add(1);
            //    for (int i = count; i < n; i++)
            //    {
            //        result.Add(A[i]);
            //    }
            //}
            return result;
        }
    }
}
