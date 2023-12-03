using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    internal abstract class GenericAbstractArrayList <T>: GenericIList<T> where T : IComparable
    {
        //Data Members
        protected T[] Data;//array of data

        public int Size { get; set; }
        public int CIndex { get; set; }

        //Method
        //constructor
        public GenericAbstractArrayList(int size)
        {
            Data = new T[size];//allocate memory to the array
            this.Size = size;//initialize size
            this.CIndex = 0;//initialize index
        }
        public void Insert(T item)
        {
            Data[CIndex++] = item;
        }
        public abstract void Update(T item);
        public abstract void Remove(T item);
        public abstract void RemoveAll(T item);

        public string ShowAll()
        {
            string r = "";
            foreach (T i in Data)
            {   
                r += "\t" + i;
            }
            return r;
        }
    }
}
