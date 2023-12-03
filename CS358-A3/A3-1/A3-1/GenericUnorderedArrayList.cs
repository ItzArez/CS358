using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11AbstractInterfaceExample
{
    internal class GenericUnorderedArrayList<T> : GenericAbstractArrayList<T> where T : IComparable
    {
        public GenericUnorderedArrayList(int size) : base(size)
        {
        }

        public override void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public override void RemoveAll(T item)
        {
            for (int i = 0; i< CIndex; i++)
            {
                Data[i] = default(T);
            }
        }

        public override void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
