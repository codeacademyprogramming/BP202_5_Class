using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    internal class Book:Product
    {
        public Book(string author,double price):base(price)
        {
            this.Author = author;
        }

        public Book(string author,double price,double discountPercent) : base(price, discountPercent)
        {
            this.Author= author;
        }

        public string Author;
        public string Genre;
    }
}
