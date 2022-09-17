using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision.TwoDimensionalArray
{
    public class SumOfAllSubMatrix
    {
        public int SumAllSubMatrix(List<List<int>> A)
        {
            int sum = 0;

            int rows = A.Count;
            int cols = A[0].Count;

            for(int i= 0; i<rows; i++)
            {
                for (int j=0; j<cols; j++)
                {
                    int contribution = (i + 1) * (j + 1) * (rows - i) * (cols - j);
                    sum= sum + contribution * A[i][j];
                }
            }

            return sum;
        }
    }
}
