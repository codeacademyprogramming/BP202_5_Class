using System;
using System.Collections.Generic;
using System.Text;

namespace _18032022
{
    internal class Car
    {
        public Car(int millage,int year)
        {
            Millage = millage;
            Year = year;
            Console.WriteLine("Car yaradildi");
        }

        public Car(int millage,string model,string brand)
        {
            this.Millage =millage;
            Model = model;
            Brand = brand;
        }

        public Car()
        {

        }

        public int Year;
        public int Millage;
        public string Model;
        public string Brand;
        public void Drive(int km)
        {
            Millage += km;
        }
    }
}
