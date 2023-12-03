using System;
using A3;

class GFG
{
    static public void Main(String[] args)
    {
        /*
        LinkedList list = new LinkedList();

        list.Insert(5);
        list.Insert(2);
        list.Insert(9);
        list.Insert(1);
        list.Insert(5);

        Console.WriteLine("Linked List elements before sorting:");
        list.PrintList();

        // Sort the linked list using Bubble Sort
        list.BubbleSort();

        Console.WriteLine("Linked List elements after sorting:");
        list.PrintList();*/


        GenericLinkedList<int> intList = new GenericLinkedList<int>();
        intList.Insert(5);
        intList.Insert(2);
        intList.Insert(9);
        intList.Insert(1);
        intList.Insert(5);

        Console.WriteLine("Integer Linked List elements before sorting:");
        intList.PrintList();

        // Sort the integer linked list using Insertion Sort
        intList.InsertionSort();

        Console.WriteLine("Integer Linked List elements after sorting:");
        intList.PrintList();

        GenericLinkedList<string> stringList = new GenericLinkedList<string>();
        stringList.Insert("apple");
        stringList.Insert("orange");
        stringList.Insert("banana");
        stringList.Insert("grape");
        stringList.Insert("kiwi");

        Console.WriteLine("String Linked List elements before sorting:");
        stringList.PrintList();

        // Sort the string linked list using Insertion Sort
        stringList.InsertionSort();

        Console.WriteLine("String Linked List elements after sorting:");
        stringList.PrintList();

    }
}



