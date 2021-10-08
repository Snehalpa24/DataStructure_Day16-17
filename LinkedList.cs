using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureUsingLinkedList
{
    public class LinkedList
    {
        public Node head;

        /// <summary>
        /// Add methode to add the specific data into linked list
        /// </summary>
        /// <param name="data">The data.</param>
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
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
            Console.WriteLine("inserted into the linked list", node.data);
        }

        /// <summary>
        /// Add2 methode to add the specified data into linked list.
        /// </summary>
        /// <param name="data">The data.</param>
        internal void Add2(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                node.next = head;
                this.head = node;
            }
            Console.WriteLine("inserted into the linked list", node.data);
        }

        /// <summary>
        /// Display methode for display the specific data.
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            Console.WriteLine("Squence of linked list = ");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Inserts at particular poistion ie 2.
        /// </summary>
        /// <param name="poistion">The poistion.</param>
        /// <param name="data">The data.</param>
        /// <returns>data at second poistion</returns>
        public Node InsertAtParticularPoistion(int poistion,int data)
        {
            if (poistion < 1)
                Console.WriteLine("Invalid Poistion");
            if (poistion == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while(poistion-- != 0)
                {
                    if (poistion == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (poistion != 1)
                    Console.WriteLine("poistion out of range");
            }
            return head;
        }

        /// <summary>
        /// Removes the first node from list.
        /// </summary>
        /// <returns>deleted node</returns>
        internal Node removeFirstNode()
        {
            if (this.head == null)
                return null;
            Node temp = head;
            head = head.next;
            return temp;
        }

        /// <summary>
        /// Removes the last node from list.
        /// </summary>
        /// <returns>deleted node</returns>
        internal Node removeLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            Node lastElement = newNode.next;
            newNode.next = null;
            return lastElement;
        }

        /// <summary>
        /// Searches the specified node with value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>node</returns>
        public Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
        }

        /// <summary>
        /// Finds the poistion.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>position</returns>
        public int findPoistion(int value)
        {
            int position = 0;
            while (this.head != null)
            {
                position++;
                if (this.head.data == value)
                {
                    return position;
                }
                this.head = this.head.next;
            }
            return position;
        }

        /// <summary>
        /// Deletes the node.
        /// </summary>
        /// <param name="deletData">The delet data.</param>
        public void deleteNode(int deletData)
        {
            if (this.head == null)
                return;
            else if (this.head.data == deletData && this.head.next == null)
                this.head = null;
            else if (this.head.data == deletData)
                this.head = this.head.next;
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    if (temp.next.data == deletData)
                    {
                        temp.next=temp.next.next;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns>size</returns>
        public int size()
        {
            int size = 0;
            Node temp = this.head;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }
    }
}
