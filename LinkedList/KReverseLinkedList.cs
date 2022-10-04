using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class KReverseLinkedList
    {

        public void Reverse(Node start, Node end)
        {
            Node prev = null;
            Node curr = start;
            Node next = start.next;
            Node endNext = end.next;

            while(prev!=end)
            {
                curr.next = prev;
                prev= curr;
                curr= next;
                next = next.next;
            }
            start.next = endNext;
        }
        
        public SingleLinkedList ReverseStartEnd(SingleLinkedList singleLinkedList)
        {
            Node temp = singleLinkedList.head;
            Node end = temp.next.next.next;
            Reverse(temp, end);

            singleLinkedList.head = end;
            return singleLinkedList;
        }
        public SingleLinkedList  KReverse(SingleLinkedList singleLinkedList, int k)
        {

            if (singleLinkedList.head == null || singleLinkedList.head.next == null)
                return singleLinkedList;

            // creating dummy node
            Node dummy = new Node(-1);
            dummy.next = singleLinkedList.head;

            // Initializing three points prev, curr, next
            Node prev = dummy;
            Node curr = dummy;
            Node next = dummy;

            // Calculating the length of linked list
            int count = 0;
            while (curr != null)
            {
                count++;
                curr = curr.next;
            }

            // Iterating till next is not NULL
            while (next != null)
            {
                curr = prev.next; // Curr position after every
                                  // reverse group
                next = curr.next; // Next will always next to
                                  // curr

                int toLoop
                    = count > k
                          ? k
                          : count - 1; // toLoop will set to
                                       // count - 1 in case of
                                       // remaining element

                for (int i = 1; i < toLoop; i++)
                {
                    // 4 steps as discussed above
                    curr.next = next.next;
                    next.next = prev.next;
                    prev.next = next;
                    next = curr.next;
                }

                prev = curr; // Setting prev to curr
                count -= k; // Update count
            }

            singleLinkedList.head = dummy.next;
            return singleLinkedList;
        }
    }
}
