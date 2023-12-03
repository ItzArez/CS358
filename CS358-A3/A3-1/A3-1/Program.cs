using Ch11AbstractInterfaceExample;
using System;
using System.Collections.Generic;

namespace AbstractDataTypes
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            dynamic d1 = "zzz";
            dynamic d2 = "aaa";
            dynamic d3 = "hhh";
            dynamic d4 = "ddd";
            */

            dynamic d1 = 5.17m;
            dynamic d2 = 4.13m;
            dynamic d3 = 9.14m;
            dynamic d4 = 0.81m;

            GenericOrderedArrayList<decimal> goal_dynamic = new GenericOrderedArrayList<decimal>(10);
            goal_dynamic.Insert(d1);
            goal_dynamic.Insert(d2);
            goal_dynamic.Insert(d3);
            goal_dynamic.Insert(d4);
            string s_dynamic = goal_dynamic.ShowAll();//before
            Console.WriteLine(s_dynamic);
            goal_dynamic.BubbleSort();
            goal_dynamic.InsertionSort();//sort the list
            s_dynamic = goal_dynamic.ShowAll();//after
            Console.WriteLine(s_dynamic);
        }
    }
}
