using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDay14
{
    class UC4AddInBetn
    {
        internal Node head;

        //UC2 Add To list
        internal void AddToFront(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;

            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        //UC3 Appending to list
        internal void AddToEnd(int data)
        {

            Node node = new Node(data);

            if (this.head == null)

                this.head = node;

            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);

        }

        //UC4 Add in between

        internal Node AddInBet(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (position-- != 0) 
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;

                    }
                    temp = temp.next;

                }

                if (position != 1)
                    Console.WriteLine("Position out of range");

            }
            return head;
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
