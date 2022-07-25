using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortaStack sortaStack = new SortaStack();
            Console.WriteLine(sortaStack.Solve(new List<int> { 5, 12, 1, 23 }));
            Console.ReadLine();
        }
    }
}
