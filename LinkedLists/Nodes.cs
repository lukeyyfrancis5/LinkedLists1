using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    /*#2
    class Node
    {
        public string text;
        public Node next;
    }

    public class LinkedList
    {
        private Node head;

        public void Print()
        {
            Node next = head;
            while (next != null)
            {
                Console.Write("|" + next.text + "|---");
                next = next.next;
            }
        }

        public void Addfirst(string text)
        {
           Node headNode = new Node();

            headNode.text = text;
            headNode.next = head;

            head = headNode;
        }

        public void AddLast(string text)
        {
            if (head == null)
            {
                head = new Node();
                head.text = text;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.text = text;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;


            }
        }
    }  */
}
