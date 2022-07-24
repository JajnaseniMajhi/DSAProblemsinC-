using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            FreeCars freeCars = new FreeCars();
            freeCars.Solve(new List<int>() { 1, 7, 6, 2, 8, 4, 4, 6, 8, 2 }, new List<int>() { 8, 11, 7, 7, 10, 8, 7, 5, 4, 9 });
            Console.ReadLine();
        }
    }
}
