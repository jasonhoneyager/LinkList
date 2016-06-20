using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class List
    {
        private Node head = new Node();
        public List()
        {
            head.data = null;
            head.next = null;
        }
        
        public void AddToList(string newdata)
        {
           if (head.data == null)
            {
                head.data = newdata;
            }
           else
            {
                Node addnode = new Node();
                addnode.data = newdata;
                AddToEnd(addnode);
            }
        }

        private void AddToEnd(Node addnode)
        {
            Node currentnode = head;
            while (true)
            {
                if (currentnode.next != null)
                {
                    currentnode = currentnode.next;
                }
                else
                {
                    break;
                }
            }
            currentnode.next = addnode;
        }

        public void EndOfList(string newdata)
        {
            if (head == null)
            {
                head = new Node();
                head.data = newdata;
                head.next = null;
            }
            else
            {
                Node addnode = new Node();
                addnode.data = newdata;

                Node Last = head;
                while (Last.next != null)
                {
                    Last = Last.next;
                }
                Last.next = addnode;
            }
        }

        public void PrintList()
        {
            Node print = head;
            while (print != null)
            {
                Console.WriteLine(print.data);
                print = print.next;
            }
        }
    }
}
