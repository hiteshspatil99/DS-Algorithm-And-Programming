using System;
using System.Collections.Generic;
using System.Text;

namespace DS_Algorithm.Utility
{
    class QueueList<T> where T : IComparable
    {
        internal Node<T> front;
        internal Node<T> rear;

        internal void Queues()
        {
            this.front = null;
            this.rear = null;
        }
        internal void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (front == null)
            {
                front = node;
                rear = node;
            }
            else
            {
                rear.next = node;
                rear = node;
            }
            Console.WriteLine("Data is added  to the Queue" + data);
        }
        internal void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node<T> temp = front;
                Console.Write("Element in Queue is :");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine(" ");
            }
        }
        internal void Dequeue() // To Remove Data From Queues
        {
            if (front == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("Perform Dequeue");
                front = front.next;
            }
        }
        internal int IsEmpty()
        {
            if (this.front != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
