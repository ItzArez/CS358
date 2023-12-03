using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{

    class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    internal class GenericLinkedList<T>
    {
        private Node<T> Head;

        public void Insert(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<T> temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        public void PrintList()
        {
            Node<T> temp = Head;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public void InsertionSort()
        {
            if (Head == null || Head.Next == null)
            {
                return;
            }

            Node<T> sorted = null;
            Node<T> current = Head;

            while (current != null)
            {
                Node<T> next = current.Next;
                if (sorted == null || Comparer<T>.Default.Compare(sorted.Data, current.Data) >= 0)
                {
                    current.Next = sorted;
                    sorted = current;
                }
                else
                {
                    Node<T> temp = sorted;
                    while (temp.Next != null && Comparer<T>.Default.Compare(temp.Next.Data, current.Data) < 0)
                    {
                        temp = temp.Next;
                    }
                    current.Next = temp.Next;
                    temp.Next = current;
                }
                current = next;
            }

            Head = sorted;
        }
    }
    
}
