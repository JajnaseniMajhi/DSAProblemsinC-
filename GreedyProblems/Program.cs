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
            MiceToHolesProblem freeCars = new MiceToHolesProblem();
           Console.Write( freeCars.Solve(new List<int>() { -4, 2, 3 }, new List<int>() { 0, -2, 4 }));
            Console.ReadLine();
        }
    }
}
