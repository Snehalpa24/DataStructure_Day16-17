using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureUsingStackAndQueue
{
    class LinkedListQueue
    {
        Node head = null;

        /// <summary>
        /// Enqueues methode to add the specified data in queue.
        /// </summary>
        /// <param name="data">The data.</param>
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("\n inserted into queue = " + node.data);
        }

        /// <summary>
        /// Dequeues this element from stack.
        /// </summary>
        internal void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                head = head.next;
            }
        }

        /// <summary>
        /// Displays this elements in queue.
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
