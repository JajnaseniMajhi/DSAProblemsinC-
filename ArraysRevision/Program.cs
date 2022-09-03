using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysRevision
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // BeggerTemple begger = new BeggerTemple();

           // List<List<int>> input = new List<List<int>>();
           // input.Add(new List<int>() { 1, 2, 10 });
           // input.Add(new List<int>() { 2, 3, 20 });
           // input.Add(new List<int>() { 2, 5, 25 });
           //var result= begger.solve(5, input);

          //  PickFromBothSides pickFromBothSides= new PickFromBothSides();
          //var result=  pickFromBothSides.solve(new List<int>() { 5, -2, 3, 1, 2 }, 3);
          MaximumSumSubArray maximumSumSubArray = new MaximumSumSubArray();
            var result = maximumSumSubArray.MaximumSum(new List<int>() { 1, 2, 3, 4, -10 });
            Console.ReadLine();
        }
    }
}
