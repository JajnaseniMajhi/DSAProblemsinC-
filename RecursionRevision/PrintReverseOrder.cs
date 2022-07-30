using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionRevision
{
    public class PrintReverseOrder
    {
        public void printReverseOrder(int n)
        {
            if(n == 1)
            {
                Console.WriteLine(1);
                return;
            }
            Console.WriteLine(n);
            printReverseOrder(n - 1);
        }

        public void PrintCorrectOrder(int n)
        {
            if(n==1)
            {
                Console.WriteLine(1);
                return;
            }
            PrintCorrectOrder(n - 1);
            Console.WriteLine(n);
        }
    }
}
