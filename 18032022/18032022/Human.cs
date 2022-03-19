using System;
using System.Collections.Generic;
using System.Text;

namespace _18032022
{
    internal class Human
    {
        public Human(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;

            Console.WriteLine("Insan yarandi");
        }
        public Human()
        {

        }
        public string Name;
        public string Surname;
        public byte Age;
        public string Gender;

        public string GetFullName()
        {
            return Name + " " + Surname;
        }


    }
}
