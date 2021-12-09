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
            list.InsertBegin(70);
            list.InsertBegin(30);
            list.InsertBegin(56);
            list.Display();
            Console.ReadKey();
        }
    }
}
