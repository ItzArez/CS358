using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    interface GenericIList <T>
    {
        void Insert(T item);
        void Update(T item);
        void Remove(T item);
        void RemoveAll(T item);
    }

    internal interface GenericIList
    {
    }
}
