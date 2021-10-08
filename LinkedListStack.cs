using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureUsingStackAndQueue
{
    class LinkedListStack
    {
        public Node top;

        /// <summary>
        /// Parameterized constructor to Initializes a new instance of the <see cref="LinkedListStack"/> class.
        /// </summary>
        public LinkedListStack()
        {
            this.top = null;
        }

        /// <summary>
        /// Pushes the specified value into stack.
        /// </summary>
        /// <param name="value">The value.</param>
        internal void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(value);
        }

        /// <summary>
        /// Peek methode return the top element in stack.
        /// </summary>
        internal void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
            }
            Console.WriteLine("\n is in the top of stack = " + this.top.data);
        }

        /// <summary>
        /// Pop methode remove and return the top element.
        /// </summary>
        internal void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty \n deletion is not possible");
            }
            Console.WriteLine("\n Pop out elememnt is = " + this.top.data);
            this.top = this.top.next;
        }

        /// <summary>
        /// Determines whether this stack is empty or not.
        /// </summary>
        internal void isEmpty()
        {
            while (this.top != null)
            {
                peek();
                pop();
            }
            Console.WriteLine("Stack is empty");
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine("elements in stack = " + temp.data);
                temp = temp.next;
            }
        }
    }
}
