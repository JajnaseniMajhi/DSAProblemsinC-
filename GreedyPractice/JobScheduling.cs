using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyPractice
{
    public class Job
    {
        public int id;
        public int deadLine;
        public int profit;
    }
    public  class JobScheduling
    {

        public void ScheduleJobMaxProfit(Job[] jobList, int nosOfJobs)
        {
            Array.Sort(jobList, new ProfitComparer());

            //Find max deadline
            int maxD = int.MinValue;
            for(int i=0; i<jobList.Length;i++)
            {
                if (jobList[i].deadLine>maxD)
                {
                    maxD = jobList[i].deadLine;
                }
            }

            bool[] slotSAvailable= new bool[maxD+1];

            int totalProfit = 0;
            int jobCount = 0;

            for(int i=0;i<jobList.Length; i++)
            {
                Job currJob = jobList[i];

                for (int j = currJob.deadLine; j > 0; j--)
                {
                    if (slotSAvailable[j] == false)
                    {
                        jobCount = jobCount + 1;
                        slotSAvailable[j] = true;
                        totalProfit = totalProfit + currJob.profit;
                        break;
                    }
                }
                            

            }

            Console.WriteLine("Total profit {0}", totalProfit);
            Console.Write("Job Count {0}", jobCount);
            }
        }
    

    public class ProfitComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Job job1 = x as Job;
            Job job2= y as Job;
            if(job1.profit>job2.profit)

            {
                return -1;
            }
            if(job1.profit<job2.profit)
            {
                return 1;
            }

            return 0;
        }
    }
}
