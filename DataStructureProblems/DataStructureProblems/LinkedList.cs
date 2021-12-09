using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }        
    }
    class LinkedList
    {
        Node head;
        public void InsertBegin(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                node.next = temp;
                head = node;                
            }
            Console.WriteLine("Element {0} added to the linked list", node.data);
        }
        public void InsertEnd(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                
            }
            Console.WriteLine("Element {0} added to the linked list", node.data);
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked List is empty");
            else
                while(temp!=null)
                {
                    Console.Write("{0}  ",temp.data);
                    temp = temp.next;
                }
            
        }

    }
}
