using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphProblemProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IsPathExists isPathExists = new IsPathExists();
            //List<List<int>> list = new List<List<int>>();
            //list.Add(new List<int>() { 1,2});
            //list.Add(new List<int>() { 4,1 });
            //list.Add(new List<int>() { 2,4 });
            //list.Add(new List<int>() { 3,4 });
            //list.Add(new List<int>() { 5, 2 });
            //list.Add(new List<int>() { 1, 3 });

            //Console.WriteLine(isPathExists.IsPathThere(5,list));

            FDFS fDFS = new FDFS();

            Console.WriteLine(fDFS.solve(new List<int>() { 1, 1, 2 }, 1, 2));
            Console.ReadLine();
        }
    }
}
