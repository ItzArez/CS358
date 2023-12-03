using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11AbstractInterfaceExample
{
    internal class GenericOrderedArrayList<T> : GenericAbstractArrayList<T> where T : IComparable
    {
        public GenericOrderedArrayList(int size) : base(size)
        {
        }

        public override void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public override void RemoveAll(T item)
        {
            throw new NotImplementedException();
        }

        public override void Update(T item)
        {
            throw new NotImplementedException();
        }
        public void InsertionSort()
        {
            for (int i = 1; i < CIndex; ++i)
            {
                T key = Data[i];
                int j = i - 1;

                // Move elements of arr[0..i-1] that are greater than key
                // to one position ahead of their current position
                while (j >= 0 && Data[j].CompareTo( key) > 0)
                {
                    Data[j + 1] = Data[j];
                    j = j - 1;
                }
                Data[j + 1] = key;
            }
        }

        public void BubbleSort()
        {   
            for (int i = 0; i < CIndex; i++)
            //for (int i = 0; i < n - 1; i++)
            {
                if (Data[i] == null) continue;
                for (int j = 0; j < CIndex - i - 1; j++)
                {
                    // Swap if the element found is greater than the next element
                    if (Data[j].CompareTo(Data[j+1]) > 0)
                    {
                        // Swap array[j] and array[j+1]
                        T temp = Data[j];
                        Data[j] = Data[j + 1];
                        Data[j + 1] = temp;
                    }
                }
            }
        }
    }
}
