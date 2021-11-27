using System;
using System.Collections.Generic;
using System.Text;

namespace DS_Algorithm.Utility
{
    class StackQueueList<T> where T : IComparable
    {
        Node<T> top;
        public StackQueueList()
        {
            this.top = null;
        }
        public T Push(T data)
        {
            Node<T> newnode = new Node<T>(data);
            if (top == null)
            {
                newnode.next = null;
            }
            else
            {
                newnode.next = top;
            }
            top = newnode;
            Console.WriteLine("{0} item Pushed to Stack ", newnode.data);
            return data;
        }
        internal void Pop(T data)
        {
            if (top == null)
            {
                Console.WriteLine("Stack is in Undeflow Condition");
                return;
            }
            Console.WriteLine("{0} item poped out from Stack", top.data);
            top = top.next;
        }
        internal void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is in Undeflow Condition");
                return;
            }
            Console.WriteLine("{0},is on the top of the Stack", this.top.data);
        }
        internal void Display()
        {
            Node<T> temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal bool IsEmpty()
        {
            Node<T> temp = this.top;
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return true;
            }
            return false;
        }
    }
}
