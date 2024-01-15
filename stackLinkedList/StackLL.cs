using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace stackLinkedList
{
    public  class StackLL:Interface1
    {
        Node head;

        public void InsertAtBottom(string value)
        {
            if (IsEmpty())
            {
                Push(value);
            }
            else
            {
                // Hold the top item and insert the rest at the bottom
                string topItem = (string)Peek();
                Pop();
                InsertAtBottom(value);

                // Push the top item back onto the stack
                Push(topItem);
            }
        }

        public void Reverse()
        {
            if (!IsEmpty())
            {
                // Hold the top item and reverse the rest of the stack
                string topItem = (string)Peek();
                Pop();
                Reverse();

                // Insert the top item at the bottom
                InsertAtBottom(topItem);
            }
        }

        public bool IsEmpty()
        {
            return head == null;
        }
        public object Peek()
        {
            // check for empty stack
            if (!IsEmpty())
            {
                return head.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }

        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public int Pop()
        {
            // check for stack underflow
            if (IsEmpty())
            {
                Console.Write("\nStack Underflow");
                return 0;
            }

            // update the top pointer to
            // point to the next node
            head = (head).next;
            return 0;
        }

        public void Push(string value)
        {
            // create new node temp and allocate memory
            Node temp = new Node();

            // check if stack (heap) is full.
            // Then inserting an element
            // would lead to stack overflow
            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }

            // initialize data into temp data field
              temp.data = value;

            // put top reference into temp link
             temp.next = head;

            // update top reference
            head = temp;

        }

        public int getCount()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

        public int Size()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
               temp = temp.next;
            }

            return count;
        }

        
    }
}

