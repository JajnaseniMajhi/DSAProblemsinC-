using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   
    public class Node
    {
        public int value;
        public Node next;
        public Node(int _value)
        {
            value = _value;
        }
    }

    public class SingleLinkedList
    {
        public Node head;
        public SingleLinkedList(Node head)
        {
            this.head = head;
        }

        public void AddatHead(int value)
        {
            Node node= new Node(value);
            if (head == null)
            {
                head = node;
                return;
            }
                node.next = head;
                head = node;
            
        }

        public void AddAtEnd(int value)
        {
            Node node = new Node(value);
            if (head== null)
            {
                head = node;
                return;
            }

            Node temp = head;
            while(temp.next!=null)
            {
                temp = temp.next;
            }

            temp.next = node;
        }

        public void InsertAfter(int value, Node prevNode)
        {
            if (prevNode == null)
            {
                return;

            }
            Node node = new Node(value);
            Node temp = prevNode.next;
            prevNode.next = node;
            node.next = temp;

        }

        public void DeleteNodeByValue(int value)
        {
            if(head==null)
            {
                return ;
            }
            Node temp = head;
            Node prev = null;
            while(temp!=null && temp.value!=value)
            {
                prev=temp;
                temp = temp.next;
            }

            if(temp==null)
            {
                return ;
            }

            if (prev != null)
            {
                prev.next = temp.next;
            }
            else if(head!=null)
            {
                head = temp.next;
            }
            temp.next = null;

        }

        public void PrintAllNodes()
        {
            if(head ==null)
            {
                return;
            }
            Node temp = head;
            while(temp!=null)
            {
                Console.WriteLine(temp.value + ": ");
                temp = temp.next;

            }
        }
    }

    public class CreateLinkedList
    {
        public void OperateLinkedList()
        {
            Node head = new Node(0);
            SingleLinkedList singleLinkedList = new SingleLinkedList(head);
            singleLinkedList.AddatHead(1);
            singleLinkedList.AddatHead(2);
            singleLinkedList.AddatHead(3);
            singleLinkedList.AddatHead(4);
            singleLinkedList.AddatHead(5);
            singleLinkedList.AddatHead(6);
            singleLinkedList.AddatHead(7);
            singleLinkedList.AddatHead(8);
            singleLinkedList.AddatHead(9);
            singleLinkedList.PrintAllNodes();
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Reversed List");
            //ReverseLinkedList reverseLinkedList= new ReverseLinkedList();
            //var result= reverseLinkedList.ReverseLinkedListBtoC(singleLinkedList,2,4);
            KReverseLinkedList kReverseLinkedList = new KReverseLinkedList();
            var result = kReverseLinkedList.ReverseStartEnd(singleLinkedList);
            result.PrintAllNodes();




        }
    }
}
