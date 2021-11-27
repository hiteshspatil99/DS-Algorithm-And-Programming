using System;
using System.Collections.Generic;
using System.Text;

namespace DS_Algorithm.Utility
{
    class QueueOperation<T> where T : IComparable
    {
        Node<T> front;
        Node<T> rear;
        public QueueOperation()
        {
            this.front = this.rear = null;
        }
        internal T Enqueue(T data)
        {
            Node<T> newnode = new Node<T>(data);
            if (this.rear == null)
            {
                this.front = this.rear = newnode;
            }
            else
            {
                this.rear.next = newnode;
                this.rear = newnode;
            }
            Console.WriteLine("{0} is inserted into queue", newnode.data);
            return data;
        }
        internal T DeQueue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Node<T> temp = this.front;
            this.front = this.front.next;
            if (this.front == null)
            {
                this.rear = null;
            }
            Console.WriteLine("{0} is deleted from the queue", temp.data);
            return temp.data;
        }
        public bool IsEmpty()
        {
            if (this.front == null)
            {
                Console.WriteLine("queue is empty");
                return true;
            }
            else
                Console.WriteLine("Queue is not empty");
            return false;
        }
    }
}
