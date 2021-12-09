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
            list.Display();
            Console.ReadKey();
        }
    }
}
