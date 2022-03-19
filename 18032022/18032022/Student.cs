using System;
using System.Collections.Generic;
using System.Text;

namespace _18032022
{
    internal class Student:Human
    {
        public Student(string name,string surname):base(name,surname)
        {
            Console.WriteLine("Telebe yarandi");
        }
        public string GroupNo;
    }
}
