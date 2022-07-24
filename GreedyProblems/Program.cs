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
            FindMaximumJobs freeCars = new FindMaximumJobs();
            freeCars.Solve(new List<int>() { 3, 2, 6 }, new List<int>() { 9, 8, 9 });
            Console.ReadLine();
        }
    }
}
