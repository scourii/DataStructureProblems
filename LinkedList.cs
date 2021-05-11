using System;

namespace DataStructProblems
{
    public class LinkedList
    {
        public class Node
        {
            internal int data; //Data to store (could be int,string,object etc)
            internal Node nextElement; //Pointer to next element
            public Node()
            {
                //Constructor to initialize nextElement of newlyCreated Node
                nextElement = null;
            }
        };
        Node head;
        public LinkedList()
        {
            head = null;
        }
        public bool IsEmpty()
        {
            if (head == null) //Check whether the head points to null
                return true;
            else
                return false;
        }
        //Function inserts a value/new Node as the first Element of list
        public bool PrintList()
        {        // Printing the list
            if (IsEmpty())
            {
                Console.Write("List is Empty!");
                return false;
            }
            Node temp = head;        // starting from head node
            Console.Write("List : ");
            while (temp != null)
            {     // traveresing through the List
                Console.Write(temp.data + "->");
                temp = temp.nextElement;    // moving on to the temp's nextElement
            }
            Console.WriteLine("null ");    // printing null at the end
            return true;
        }
        private void InsertAtHead(int value)
        {
            Node newNode = new Node();
            newNode.data = value;
            newNode.nextElement = head;
            head = newNode;
        }
        private void InsertAtTail(int value)
        {
            if (IsEmpty())
            {
                InsertAtHead(value);
            }
            else
            {
                Node newNode = new Node();
                Node last = head;
                while (last.nextElement != null)
                {
                    last = last.nextElement;
                }
                newNode.data = value;
                newNode.nextElement = null;
                last.nextElement = newNode;
                Console.WriteLine($"{value} was inserted into the Linked List!");
            }
        }
    }
}
