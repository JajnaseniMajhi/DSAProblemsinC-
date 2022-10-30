using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPractice
{
    internal class BufgetProblem

    { 

  
        public  double FindGrantsCap(double[] grantsArray, double newBudget)
        {
            double minValue = FindMin(grantsArray);
            double sumMin =Math.Round( newBudget / grantsArray.Length,2);
            minValue = Math.Min(minValue, sumMin);

            double maxValue = newBudget;
            double result = 0;
            while (minValue < maxValue)
            {
                double mid =Math.Round( (minValue + maxValue) / 2,2);
                if (ValidateAllocation(grantsArray, mid, newBudget))
                {
                    result = mid;
                    minValue = mid;
                }
                else
                {
                    maxValue = mid;
                }
            }
            // your code goes here
            return result;
        }

        
        private  bool ValidateAllocation(double[] grantsArray, double budget, double totalBudget)
        {
            double sum = 0;
            for (int i = 0; i < grantsArray.Length; i++)
            {
                if (grantsArray[i] < budget)
                {
                    sum = sum + grantsArray[i];
                }
                else
                {
                    sum = sum + budget;
                }
                if (sum > totalBudget)
                {
                    return false;
                }
            }

            return true;
        }

        private  double FindMin(double[] grantsArray)
        {
            double min = double.MaxValue;
            for (int i = 0; i < grantsArray.Length; i++)
            {
                min = Math.Min(grantsArray[i], min);
            }
            return min;
        }
        //private static double FindSum(double[] grantsArray)
        //{
        //    double sum = 0;
        //    for (int i = 0; i < grantsArray.Length; i++)
        //    {
        //        sum = sum + grantsArray[i];
        //    }
        //    return sum;
        //}
    }


}


