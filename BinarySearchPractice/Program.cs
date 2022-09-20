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

            List<int> input = new List<int> { 1, 4, 8, 78, 79, 88 };
            //FindTargetElement findTargetElement = new FindTargetElement();
            //Console.WriteLine(findTargetElement.FindATarget(new List<int> { 1, 4, 8, 78, 79, 88 }, 11));
            InsertSortedElement insertSortedElement = new InsertSortedElement();
            Console.WriteLine(insertSortedElement.GetInsertSortedElement(input, 81));
            Console.ReadLine();

        }
    }
}
