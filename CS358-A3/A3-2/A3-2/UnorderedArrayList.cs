using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    internal class UnorderedArrayList : AbstractArrayList
    {
        //constructor
        public UnorderedArrayList(int size) : base(size)//calling the base/parent constructor
        {

        }
        public override int Insert(int i)
        {
            data[CIndex++] = i;
            //data[CIndex] = i;
            //CIndex += 1;
            return CIndex;
        }
    }
}
