using RecursionRevision.StringRecursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionRevision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintReverseOrder obj = new PrintReverseOrder();
            //obj.printReverseOrder(5);
            // CheckArraySorted checkArraySorted = new CheckArraySorted();
            //var result= checkArraySorted.Issorted(new List<int>() { 3, 4, 7,8 }, 0);
            //SearchElement searchElement = new SearchElement();
            //var result = searchElement.IsFound(new List<int>() { 2, 3, 4, 1, 25, 8 }, 8, 0);
            //Console.Write(result);

            //PatternSort.PatternProblems patternProblems = new PatternSort.PatternProblems();
            //patternProblems.PrintPattern(4);
            RemoveChar removeChar = new RemoveChar();
            removeChar.Solve("aaaBcaaDe", 0, new StringBuilder());
;
            Console.ReadLine();
        }
    }
}
