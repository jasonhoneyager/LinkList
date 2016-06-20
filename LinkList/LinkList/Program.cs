using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.AddToList("This ");
            list.AddToList("Is ");
            list.AddToList("Printing ");
            list.AddToList("A ");
            list.AddToList("Linked ");
            list.AddToList("List");
            list.EndOfList(".");
            list.PrintList();
            Console.ReadKey();
        }
    }
}
