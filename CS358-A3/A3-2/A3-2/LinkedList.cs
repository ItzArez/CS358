using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    internal class LinkedList
    {
        private Node Head;

        public void AddNode(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        public void PrintList()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public void RemoveNode(int target)
        {
            Node temp = Head;
            Node prev = null;

            while (temp != null && temp.Data != target)
            {
                prev = temp;
                temp = temp.Next;
            }

            // If the target node is not present in the list
            if (temp == null)
            {
                Console.WriteLine("Node with value " + target + " not found in the list.");
                return;
            }

            // If the target node is the first node
            if (prev == null)
            {
                Head = temp.Next;
            }
            else
            {
                prev.Next = temp.Next;
            }

            Console.WriteLine("Node with value " + target + " removed from the list.");
        }
        public void RemoveAll()
        {
            Head = null;
            Console.WriteLine("All nodes removed from the list.");
        }

        public void BubbleSort()
        {
            if (Head == null || Head.Next == null)
            {
                return;
            }

            bool swapped;
            do
            {
                swapped = false;
                Node prev = null;
                Node current = Head;
                Node next = Head.Next;

                while (next != null)
                {
                    if (current.Data > next.Data)
                    {
                        if (prev != null)
                        {
                            prev.Next = next;
                        }
                        else
                        {
                            Head = next;
                        }

                        current.Next = next.Next;
                        next.Next = current;

                        prev = next;
                        next = current.Next;

                        swapped = true;
                    }
                    else
                    {
                        prev = current;
                        current = next;
                        next = next.Next;
                    }
                }
            } while (swapped);
        }

        public void InsertionSort()
        {
            if (Head == null || Head.Next == null)
            {
                return;
            }

            Node sorted = null;
            Node current = Head;

            while (current != null)
            {
                Node next = current.Next;
                if (sorted == null || sorted.Data >= current.Data)
                {
                    current.Next = sorted;
                    sorted = current;
                }
                else
                {
                    Node temp = sorted;
                    while (temp.Next != null && temp.Next.Data < current.Data)
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
