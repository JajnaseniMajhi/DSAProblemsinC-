// See https://aka.ms/new-console-template for more information
using GreedyPractice;

Console.WriteLine("Hello, World!");

//int x = Convert.ToInt32(Console.ReadLine());
JobScheduling jobScheduling = new JobScheduling();
Job J1 = new Job();
J1.id = 1;
J1.deadLine = 2;
J1.profit = 20;
Job J2 = new Job();
J2.id = 2;
J2.deadLine = 2;
J2.profit =15 ;
Job J3 = new Job();
J3.id = 3;
J3.deadLine =1;
J3.profit = 10;
    Job J4 = new Job();
J4.id = 4;
J4.deadLine = 3;
J4.profit = 5;
Job J5 = new Job();
J5.id = 5;
J5.deadLine = 3;
J5.profit = 1;

jobScheduling.ScheduleJobMaxProfit(new Job[] { J1, J2, J3, J4, J5 }, 5);

