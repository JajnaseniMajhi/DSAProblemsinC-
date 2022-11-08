using GreedyProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractice
{
    internal class Program
    {
        public static int SubsetNumber(int[] A, int n)
        {

            int oddNoCount = 0;
            int evenNoCount = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    evenNoCount = evenNoCount + 1;
                }
                else
                {
                    oddNoCount = oddNoCount + 1;
                }
            }
            if (oddNoCount == 0)
            {
                return -1;
            }
            if (oddNoCount % 2 == 0)
            {
                return evenNoCount + oddNoCount - 1;
            }
            else
            {
                return (evenNoCount + oddNoCount);
            }
        }

        public static int UseBinarySearch(List<int> A, int X, int Y)
        {
            int l = 0;
            int r = A.Count - 1;
            while(l<=r)
            {
                int mid = (l + r) / 2;
                if (A[mid]>=X && A[mid]<=Y)
                {
                    return mid;
                }

                bool checkSum = CheckSum(mid, X, Y, A);
                if (checkSum)
                {
                    return 1;
                }

                if (A[mid]<Y)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return 0;

        }

        public static bool CheckSum(int mid,int X, int Y, List<int> A)
        {
            int sum = 0;
            for(int i=0; i<mid; i++)
            {
                sum = sum + A[i];
                if(sum>=X && sum<=Y)
                {
                    return true;
                }
            }

            if(sum >=X && sum <=Y)
            {
                return true;
            }
            sum = 0;
            for (int i = mid; i < A.Count; i++)
            {
                sum = sum + A[i];
                if (sum >= X && sum <= Y)
                {
                    return true;
                }
            }

            if (sum >= X && sum <= Y)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
