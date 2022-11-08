using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCheck
{
    //Mutex, Lock, Semaphore, Monitor etc
    public class ThreadSafePractice
    {
        Semaphore semaphore = new Semaphore(1, 1);
        int num1=0;
        int num2 = 0;
        object x = new object();
       Random random = new Random();
        public void PrintRandomNumbers()
        {
            semaphore.WaitOne();
            for (int i = 0; i < 10; i++)
            {
                
               
                   
                Console.WriteLine(i);
               
            }
            semaphore.Release();
        }
    }
}
