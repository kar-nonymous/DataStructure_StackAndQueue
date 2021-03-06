﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class Stack
    {
        public Node top;
        /// <summary>
        /// UC1:
        /// Pushes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Push(int value)
        {
            Node new_node = new Node(value);
            if (this.top != null)
                new_node.next = this.top;
            this.top = new_node;
            Console.WriteLine("Value inserted into the stack " + value);
        }
        /// <summary>
        /// Displays this content of stack.
        /// </summary>
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.next;
                }
            }
        }
        /// <summary>
        /// Displays the topmost element.
        /// </summary>
        public void Peek()
        {
            if (this.top == null)
                Console.WriteLine("\nNothing to display, stack is empty");
            else
                Console.WriteLine("\nTopmost element: " + top.data);
        }
        /// <summary>
        /// Deletes the topmost element.
        /// </summary>
        public void Pop()
        {
            if (this.top == null)
                Console.WriteLine("\nNothing to pop, the stack is empty");
            Console.WriteLine("\nValue popped is {0}", top.data);
            this.top = this.top.next;
        }
        /// <summary>
        /// UC2:
        /// Peeks and pops until the stack is empty.
        /// </summary>
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
        public Node head;
        /// <summary>
        /// UC 3
        /// Create queue and add data
        /// </summary>
        /// <param name="value">The value.</param>
        public void Enqueue(int value)
        {
            Node new_node = new Node(value);
            if (this.head != null)
                new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("Value inserted in the queue is: " + value);
        }
        /// <summary>
        /// UC 4
        /// Delete elements from the queue.
        /// </summary>
        public void Dequeue()
        {
            if (this.head == null)
                Console.WriteLine("The queue is empty");
            Node temp = this.head;
            this.head = this.head.next;
            Console.WriteLine("Element deleted is {0} ", temp.data);
        }
        public void DisplayQueue()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Nothing to display, queue is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
