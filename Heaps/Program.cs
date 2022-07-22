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

            //KPlacesApart kPlacesApart= new KPlacesApart();
            //var result = kPlacesApart.Solve(new List<int>() { 1, 40, 2, 3 }, 2);
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            //MinimimumLargestElement minimimumLargestElement = new MinimimumLargestElement();
            //minimimumLargestElement.Solve(new List<int>(){ 5, 1, 4, 2 },5);

            //  RunningMedian obj = new RunningMedian();
            //var result=  obj.solve(new List<int>() { 5, 17, 100, 11 });

            ListNode root1 = new ListNode(1);
            ListNode node1 = new ListNode(10);
            ListNode node2 = new ListNode(20);
            root1.next = node1;
            node1.next = node2;

            ListNode root2 = new ListNode(4);
            ListNode node3 = new ListNode(11);
            ListNode node4 = new ListNode(13);
            root2.next = node3;
            node3.next = node4;

            ListNode root3 = new ListNode(8);
            ListNode node5 = new ListNode(16);
            ListNode node6 = new ListNode(32);

            root3.next = node5;
            node5.next = node6;

            KSortedListMerged kSortedListMerged = new KSortedListMerged();
           var result= kSortedListMerged.mergeKLists(new List<ListNode>() { root1, root2, root3 });

           while(result.next!=null)
            {
                Console.WriteLine(result.val);
                result=result.next;
            }
            Console.WriteLine(result.val);

            Console.ReadLine();

        }
    }
}
