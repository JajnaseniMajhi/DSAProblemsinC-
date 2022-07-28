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
            Console.ReadLine();
        }
    }
}
