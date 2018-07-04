using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{/*  #1
    public class Node
    {
        int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }

        public void Print()
        {
            Console.Write("|" + data + "|->");
            if (next != null)
            {
                next.Print();
            }
        }

        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }

        public class MyList
        {
            public Node headNode;

            public MyList()
            {
                headNode = null;
            }

            public void AddToEnd(int data)
            {
                if (headNode == null)
                {
                    headNode = new Node(data);
                }
                else
                {
                    headNode.AddToEnd(data);
                }
            }

            public void Print()
            {
                if (headNode != null)
                {
                    headNode.Print();
                }
            }

        }


    }   */
}
