using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SaladOrderingF23
{
    internal class FoodItem
    {
        //data properties
        public string Name { get; set; }
        public decimal Price { get; set; }//unit price
        public int Qty { get; set; }

        //methods
        public decimal Total()
        {
            return Price * Qty;
        }
    }
}
