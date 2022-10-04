using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class ReverseLinkedList
    {
        public SingleLinkedList ReverseLinkedListExtraSpace(SingleLinkedList singleLinkedList)
        {
            Node head = singleLinkedList.head;
            SingleLinkedList revereList = new SingleLinkedList(new Node(head.value));
            while(head.next != null)
            {
                revereList.AddatHead(head.next.value);
                head= head.next;
            }

            return revereList;

        }

        public SingleLinkedList ReverseLinkedListNoExtraSpace(SingleLinkedList singleLinkedList)
        {
            Node temp= singleLinkedList.head;
            if (temp == null)
                return singleLinkedList;

            Node prev = null;
            Node curr;
            while(temp.next!=null)
            {
                curr = temp;
                temp = curr.next;
                curr.next = prev;
                prev = curr;
            }
            temp.next = prev;
            singleLinkedList.head = temp;

            return singleLinkedList;
        }


        //Reverse a linked list A from position B to C.
        public SingleLinkedList ReverseLinkedListBtoC(SingleLinkedList singleLinkedList, int B, int C)
        {
            Node revs = null, revs_prev = null;
            Node revend = null, revend_next = null;

            // Find values of above pointers.
            int i = 1;
            Node curr = singleLinkedList.head;
            while (curr != null && i <= C)
            {
                if (i < B)
                    revs_prev = curr;
                if (i == B)
                    revs = curr;
                if (i == C)
                {
                    revend = curr;
                    revend_next = curr.next;
                }
                curr = curr.next;
                i++;
            }
            revend.next = null;
            // Reverse linked list starting with revs.
            revend = reverse(revs);
            // If starting position was not head
            if (revs_prev != null)
                revs_prev.next = revend;
            // If starting position was head
            else
                singleLinkedList.head = revend;
            revs.next = revend_next;
            return singleLinkedList;
        }
        public Node reverse(Node head)
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }

    }
}
