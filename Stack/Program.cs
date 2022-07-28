using GreedyProblems;
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
            //SortaStack sortaStack = new SortaStack();
            //Console.WriteLine(sortaStack.Solve(new List<int> { 5, 12, 1, 23 }));
            //BalancedParanthesisProblem balancedParanthesisProblem = new BalancedParanthesisProblem();
            //Console.Write(balancedParanthesisProblem.Solve("({[(())]})"));
            //DoubleCharTrouble doubleCharTrouble = new DoubleCharTrouble();
            //Console.WriteLine(doubleCharTrouble.Solve("AAbCb"));
           EvaluateExpression evaluateExpression = new EvaluateExpression();
            Console.Write(evaluateExpression.evalRPN(new List<string>() { "2", "1", "+", "3", "*" }));
            Console.ReadLine();
        }
    }
}
