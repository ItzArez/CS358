using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11AbstractInterfaceExample
{
    internal abstract class AbstractArrayList : IList
    {
        //Data Members
        protected int[] data;//declare the data array//protected so child classes can access the data here.

        //properties
        public int Size { get; set; }
        public int CIndex { get; set; }

        //methods
        public AbstractArrayList(int size)
        {
            this.Size = size;//initialize the properties
            this.CIndex = 0;//initialize the properties

            data = new int[Size];//now data has the size of int memory
        }
        public void PrintAll()
        {
            for (int i = 0; i < CIndex; i++)
            {
                Console.Out.Write(data[i] + "\t");
            }
            Console.Out.WriteLine();
        }

        public abstract int Insert(int i);
        //public abstract int RemoveAt(int index);
        //public abstract int IndexOf(int i);
    }
}
