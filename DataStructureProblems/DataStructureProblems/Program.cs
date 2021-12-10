using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data structure problems");
            LinkedList list = new LinkedList();
            list.InsertEnd(56);
            list.InsertEnd(70);
            list.InsertMiddle(30,2);
            //list.Pop();
            //list.PopLast();
            list.Display();
            //list.Search(56);
            list.InsertAfter(30, 40);
            list.Display();
            list.Delete(40);
            list.Display();
            Console.WriteLine("Size of linked list is : "+list.Size());
            Console.ReadKey();
        }
    }
}
