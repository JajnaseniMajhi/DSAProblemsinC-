using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPractice
{

    public class FindMedian
    {
        public int findMedian(List<List<int>> A)
        {
            int rows = A.Count;
            int cols = A[0].Count;
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            //Find the minimum and  maximum value from the array
            for (int i = 0; i < rows; i++)
            {
                minValue = Math.Min(minValue, A[i][0]);
                maxValue = Math.Max(maxValue, A[i][cols - 1]);
            }
            int median = -1;
            int desiredCount = (rows * cols) / 2 + 1; // median will be >= half of total elements + 1
            while (minValue <= maxValue)
            {
                int midValue = minValue + (maxValue - minValue) / 2;  //it is finding the mid i.e (l+r)/2 but overflow written as l+ (r-l)/2
                int numOfElementsLessOrEqualToMidValue = 0;
                for (int rowIndex = 0; rowIndex < rows; rowIndex++)
                {
                    numOfElementsLessOrEqualToMidValue += countNumOfElementsLessOrEqualToMidValue(A, rowIndex, 0,
                            cols - 1, midValue);
                }
                if (numOfElementsLessOrEqualToMidValue >= desiredCount)
                {
                    median = midValue;
                    maxValue = midValue - 1;
                }
                else
                    minValue = midValue + 1;
            }
            return median;
        }

        private int countNumOfElementsLessOrEqualToMidValue(List<List<int>> A, int rowIndex, int startIndex, int endIndex,
                int midValue)
        {
            //int numOfElementsLessThanEqualToMidValue = 0;
            //while (startIndex <= endIndex)
            //{
            //    int midIndex = startIndex + (endIndex - startIndex) / 2;
            //    if (A[rowIndex][midIndex] <= midValue)
            //    {
            //        numOfElementsLessThanEqualToMidValue = midIndex + 1; // mid index converted to count
            //        startIndex = midIndex + 1;
            //    }
            //    else
            //        endIndex = midIndex - 1;
            //}
            //return numOfElementsLessThanEqualToMidValue;

            for (int i = endIndex; i >= startIndex; i--)
            {
                if (A[rowIndex][i] >= midValue)
                {
                    return i + 1;
                }
            }


            return 0;
        }
    }
}