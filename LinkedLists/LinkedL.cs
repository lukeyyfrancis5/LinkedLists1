using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class LinkedL
    {
        /* #3
        internal class Node
        {
            internal int data;
            internal Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }

            internal class SingleLinkedList
            {
                internal Node head;
            }

            // Insert data at the beginning of the Linked List

            internal void InsertFront(SingleLinkedList singlyList, int new_data)
            {
                Node new_node = new Node(new_data);
                new_node.next = singlyList.head;
                singlyList.head = new_node;
            }

            // Insert data at the end of the Linked List

            internal void InsertLast(SingleLinkedList singlyList, int new_data)
            {
                Node new_node = new Node(new_data);
                if (singlyList.head == null)
                {
                    singlyList.head = new_node;
                    return; 
                }

                Node lastNode = GetLastNode(singlyList);
                lastNode.next = new_node;   

            }

            internal Node GetLastNode(SingleLinkedList singlyList)
            {
                Node temp = singlyList.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                return temp;
            }
        }
        */
    }
}
