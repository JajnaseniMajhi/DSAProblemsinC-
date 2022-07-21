using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Check Heap basic functionality

            Heap minHeap = new Heap(0);
            List<int> inputList = new List<int>() { 24, -68, -29, -9, 84 };
            //minHeap.CreateMinHeap(inputList);

            ////Print the minHeapList
            //foreach(var x in minHeap.heapList)
            //{
            //    Console.WriteLine(x);
            //}

            ////Print top 3 max element

            //for (int i=0; i < 3; i++)
            //{
            //    Console.WriteLine(minHeap.getMaximumfromMaxHeap());
            //}

            //Console.WriteLine("////////////////////////////////");
            //MaximumSumAfterBNegations obj = new MaximumSumAfterBNegations();
            //Console.WriteLine(obj.Solve(inputList, 4));
            //MagicianChocolates choc = new MagicianChocolates();
            //long res= choc.nchoc(10, new List<int>() { 2147483647, 2000000014, 2147483647 });
            //Console.WriteLine(res % Math.Pow(10, 9));
            //ConnectedRopes connectedRopes = new ConnectedRopes();
            //int result= connectedRopes.Solve(new List<int>() { 5, 17, 100, 11 });
            //Console.WriteLine(result);
            AthLargest athLargest= new AthLargest();
           //var result= athLargest.Solve(2, new List<int>() { 15, 20, 99, 1 });

           // foreach(var x in result)
           // {
           //     Console.WriteLine(x);
           // }

            KPlacesApart kPlacesApart= new KPlacesApart();
            var result = kPlacesApart.Solve(new List<int>() { 1, 40, 2, 3 }, 2);
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();

        }
    }
}
