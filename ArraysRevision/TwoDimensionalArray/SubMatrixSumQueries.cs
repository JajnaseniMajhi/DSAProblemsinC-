using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision.TwoDimensionalArray
{
    public class SubMatrixSumQueries
    {
            public List<int> solve(List<List<int>> A, List<int> B, List<int> C, List<int> D, List<int> E)
            {
                int rows = A.Count;
                int cols = A[0].Count;

                List<List<long>> pfs =  CreatePFS(A, rows, cols);
                List<int> result = new List<int>();

                for (int i = 0; i < B.Count; i++)
                {
                    int srow = B[i] - 1;
                    int scol = C[i] - 1;
                    int erow = D[i] - 1;
                    int ecol = E[i] - 1;

                    long sum = pfs[erow][ecol];

                    if (srow > 0)
                    {
                        sum = sum - pfs[srow - 1][ecol];
                    }

                    if (scol > 0)
                    {
                        sum = sum - pfs[erow][scol - 1];
                    }

                    if (srow > 0 && scol > 0)
                    {
                        sum = sum + pfs[srow - 1][scol - 1];
                    }
                    sum = sum % 1000000007;
                    if (sum < 0) sum += 1000000007;

                    result.Add((int)sum);

                }

                return result;
            }
            private List<List<long>> CreatePFS(List<List<int>> A, int rows, int cols)
            {
                List<List<long>> result = new List<List<long>>();
                for (int i = 0; i < rows; i++)
                {
                    List<long> row = new List<long>();
                    for (int j = 0; j < cols; j++)
                    {
                        row.Add(0);
                    }

                    result.Add(row);
                }

            //Create row wise prefix sum
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 0)
                    {
                        result[i][j] = A[i][0];
                    }
                    else
                    {
                        result[i][j] = result[i][j - 1] + A[i][j];
                    }
                }
            }
            // Create column wise prefix sum

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (i == 0)
                    {
                        result[i][j] = result[0][j];
                    }
                    else
                    {
                        result[i][j] = result[i - 1][j] + result[i][j];

                    }
                }

            }

                return result;
            

            }

            public int solve(List<List<int>> A, int B)
            {
            int rows = A.Count;
            int cols = A[0].Count;

            var pfs = CreatePFS(A, rows, cols);

            long total;
            long maxTotal = long.MinValue;
            for(int i= B-1;i<rows; i++)
            {
                for(int j=B-1; j<cols; j++)
                {
                    total = pfs[i][j];
                    if (i-B-1>0)
                    {
                        total = total - pfs[i - B][j];
                    }

                    if(j-B-1>0)
                    {
                        total = total - pfs[i][j - B];
                    }

                    if((i-B-1>0) &&(j-B-1)>0)
                    {
                        total = total + pfs[i - B][j - B];
                    }
                    maxTotal = Math.Max(maxTotal, total);
                }
            }

            return(int)maxTotal;
            }
        }

    }

