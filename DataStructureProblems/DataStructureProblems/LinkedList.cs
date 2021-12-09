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
        Node next;
        public Node(int data)
        {
            this.data = data;
        }        
    }
    class LinkedList
    {
        Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            Console.WriteLine("Element {0} added to the linked list", node.data);
        }

    }
}
