using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCheck
{
    public class ThreadResetEvents
    {
        AutoResetEvent obj = new AutoResetEvent(false);
        public void Method1()
        {
            Console.WriteLine("I am in method1");
            Console.WriteLine("---------------------");
            Console.ReadLine();
           // obj.Set();
        }

        public void Method2()
        {
            Console.WriteLine("I am in method2");
            obj.WaitOne();
            Console.WriteLine("I am waiting");
        }
    }
}
