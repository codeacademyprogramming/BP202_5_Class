using System;

namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product product = new Product(10, 20);

            Book book = new Book("Qurban Seid", 35, 10);
            Console.WriteLine(book.GetInfo());
        }
    }
}
