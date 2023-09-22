using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadth_First_Search_Algorithm
{
    
        public class Node
        {
            public int element;
            public Node Next;
            public Node(int e, Node n)
            {
                element = e;
                Next = n;
            }
        }
        class QueueLnkedList
        {
            Node front;
            Node rear;
            int size;
            public QueueLnkedList()
            {
                front = null;
                rear = null;
                size = 0;

            }
            public int length()
            {
                return size; ;
            }
            public bool isEmpty()
            {
                return size == 0;
            }
            public void enqueue(int e)
            {
                Node newest = new Node(e, null);
                if (isEmpty())
                {
                    front = newest;
                }
                else
                {
                    rear.Next = newest;
                }
                rear = newest;
                size++;
            }
            public int dequeue()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Queue is empty");
                    return -1;
                }
                int e = front.element;
                front = front.Next;
                size--;
                if (isEmpty())
                {
                    rear = null;
                }
                return e;
            }
            public int First()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Queue is empty");
                    return -1;
                }
                return front.element;
            }
            public void display()
            {
                Node p = front;
                while (p != null)
                {
                    Console.WriteLine(p.element);
                    p = p.Next;
                }
                Console.WriteLine();
            }

        }
    }

