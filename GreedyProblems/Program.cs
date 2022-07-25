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
            // MiceToHolesProblem freeCars = new MiceToHolesProblem();
            //Console.Write( freeCars.Solve(new List<int>() { -4, 2, 3 }, new List<int>() { 0, -2, 4 }));
            // DistributeCandies distributeCandies = new DistributeCandies();
            //distributeCandies.Solve(new List<int>() { 1, 2 });
            ShipProblem shipProblem = new ShipProblem();
            shipProblem.Solve(4, 3, new List<int>() { 2, 1, 1 });
            Console.ReadLine();
        }
    }
}
