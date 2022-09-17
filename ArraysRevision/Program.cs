using ArraysRevision.Sorting;
using ArraysRevision.TwoDimensionalArray;
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

            List<List<int>> input = new List<List<int>>();
            input.Add(new List<int>() { 1, 2,3 });
            input.Add(new List<int>() { 4,5,6});
            input.Add(new List<int>() { 7, 8, 9 });
            // input.Add(new List<int>() { 2, 5, 25 });
            //var result= begger.solve(5, input);

            //  PickFromBothSides pickFromBothSides= new PickFromBothSides();
            //var result=  pickFromBothSides.solve(new List<int>() { 5, -2, 3, 1, 2 }, 3);
            //MaximumSumSubArray maximumSumSubArray = new MaximumSumSubArray();
            //  var result = maximumSumSubArray.MaximumSum(new List<int>() { 1, 2, 3, 4, -10 });
            //SumOfAllSubMatrix matrix = new SumOfAllSubMatrix();
            //var result = matrix.SumAllSubMatrix(input);
            //SubMatrixSumQueries subMatrixSumQueries = new SubMatrixSumQueries();
            //var result = subMatrixSumQueries.solve(input, new List<int>() { 1, 2 }, new List<int>() { 1, 2 }, new List<int>() { 2, 3 }, new List<int>() { 2, 3 });
            //SelectionSort selectionSort = new SelectionSort();
            //selectionSort.DoSelectionSort(new List<int>() { 10, 9, 5, -4, 8,0 });
            
            //BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.DoBubbleSort(new List<int>() { 10, 9, 5, -4, 8, 0 });
            //InsertionSort insertionSort = new InsertionSort();
            //insertionSort.DoInsertionSort(new List<int>() { 10, 9, 5, -4, 8, 0 });
            QuickSort quickSort = new QuickSort();
            quickSort.DoQuickSortPivotFirstElement(new List<int>() { 10, 9, 5, -4, 8, 0 });
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
