using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> input = new List<int> { 3,5,7, 12, 24, 22, 18, 16, 9, 1, 0 };
            //FindTargetElement findTargetElement = new FindTargetElement();
            //Console.WriteLine(findTargetElement.FindATarget(new List<int> { 1, 4, 8, 78, 79, 88 }, 11));
            //InsertSortedElement insertSortedElement = new InsertSortedElement();
            //Console.WriteLine(insertSortedElement.GetInsertSortedElement(input, 81));
            //SearchBiotonicArray searchBiotonicArray = new SearchBiotonicArray();
            //int result= searchBiotonicArray.solve(input, 0);
            //FoodDistribution foodDistribution = new FoodDistribution();
            //int result = foodDistribution.Solve(new List<int>() { 10000, 20000, 30000 }, 6);
            // FindPeakElement findPeakElement = new FindPeakElement();
            //int result= findPeakElement.FindPeakElemnt(new List<int>() { 1, 2, 3, 4, 5 });
            BufgetProblem bufgetProblem = new BufgetProblem();
            var result = bufgetProblem.FindGrantsCap(new double[] { 2, 4 }, 3);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
