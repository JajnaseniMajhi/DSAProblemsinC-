using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class EvaluateExpression
    {
        public int evalRPN(List<string> A)
        {
            var ops = new List<string>() { "+", "-", "/", "*" };
            var tempStack = new Stack<int>();
            foreach (var x in A)
            {
                if (ops.Contains(x))
                {
                    var firstElement = tempStack.Pop();
                    var secondElement = tempStack.Pop();

                    var result = Calculate(firstElement, secondElement, x);
                    tempStack.Push(result);
                }
                else
                {
                    tempStack.Push(int.Parse(x));
                }
            }

            return tempStack.Pop();
        }



        private int Calculate(int num1, int num2, string op)
        {
            switch (op)
            {
                case "+": return num1 + num2;
                case "-": return num2 - num1;
                case "*": return num1 * num2;
                case "/": return num2 / num1;
            }
            return 0;
        }
    }
}

