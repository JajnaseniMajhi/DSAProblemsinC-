using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackTracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sixlets obj = new Sixlets();
            Console.WriteLine(obj.Solve(new List<int>() { 1, 2, 8 }, 2));
            //AllCombinations allCombinations = new AllCombinations();
            //allCombinations.permute(new List<int>() { 1, 2, 3, 4 });
            Console.ReadLine();
        }
    }
}
