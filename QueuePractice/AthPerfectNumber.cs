using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePractice
{
    public class AthPerfectNumber
    {
        public string GetPerfectNumber(int A)
        {
            var queue = new Queue<string>(new[] { "11", "22" });
            var queue1 = new Queue<string>();
            var queue2 = new Queue<string>();
            if (A == 1)
            {
                return "11";
            }

            if (A == 2)
            {
                return "22";
            }

            A = A - 2;

            while (A != 0)
            {

                while (queue.Count != 0)
                {
                    var val = queue.Dequeue();
                    queue1.Enqueue(val);
                    queue2.Enqueue(val);
                }

                while (queue1.Count != 0)
                {
                    var str = "1" + queue1.Dequeue() + "1";
                    A = A - 1; ;
                    if (A == 0)
                    {
                        return str;
                    }
                    queue.Enqueue(str);
                }

                while (queue2.Count != 0)
                {
                    var str = "2" + queue2.Dequeue() + "2";
                    A = A - 1;
                    if (A == 0)
                    {
                        return str;
                    }
                    queue.Enqueue(str);
                }
            }

            return " ";
        }

        public string GetRepaeting(string A)
        {
            Queue<char> queue = new Queue<char>();
            List<int> feqList = new List<int>();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                feqList.Add(0);
            }
            for (int i = 0; i < A.Length; i++)
            {
                feqList[A[i] - 'a'] = feqList[A[i] - 'a'] + 1;
                if (feqList[A[i] - 'a'] == 1)
                {
                    queue.Enqueue(A[i]);
                }

                while (queue.Count > 0 && feqList[queue.Peek() - 'a'] > 1)
                {
                    queue.Dequeue();
                }

                if (queue.Count > 0)
                {
                    result.Append(queue.Peek());
                }
                else
                {
                    result.Append('#');
                }
            }

            return result.ToString();
        }

    }


}
