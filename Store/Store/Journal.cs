using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    internal class Journal:Product
    {
        public Journal(double price):base(price)
        {

        }

        public Journal(double price,double discountPercent) : base(price,discountPercent)
        {

        }
        public byte Month;
        public string Title;
    }
}
