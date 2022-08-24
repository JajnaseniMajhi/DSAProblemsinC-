using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class Program
    {
        static void Main(string[] args)
        {

            //LSubSequencePallindrome lSubSequencePallindrome = new LSubSequencePallindrome();
            //Console.WriteLine(lSubSequencePallindrome.solve("bebeeed"));
            CutRodProblem cutRod = new CutRodProblem();
            Console.WriteLine(cutRod.cutRods(new List<int>() { 3, 4, 1, 6, 2 }));
            Console.ReadLine();
        }
    }
}
