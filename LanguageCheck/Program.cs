// See https://aka.ms/new-console-template for more information
using LanguageCheck;

Console.WriteLine("Hello, World!");
//ThreadResetEvents obj = new ThreadResetEvents();
//AutoResetEvent auto = new AutoResetEvent(false);
ThreadSafePractice threadSafePractice = new ThreadSafePractice();
Thread t1 = new Thread(threadSafePractice.PrintRandomNumbers);
Thread t2 = new Thread(threadSafePractice.PrintRandomNumbers);
t1.Start();
t2.Start();
threadSafePractice.PrintRandomNumbers();
Console.ReadLine();
