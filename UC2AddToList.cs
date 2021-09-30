using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDay14
{
    class UC2AddToList
    {
        internal Node head;
        
        //UC2 Add to list
        internal void AddToFront(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;

            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        internal void PrintList()
        {
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }


            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next; 
            }
        }
    }
}
