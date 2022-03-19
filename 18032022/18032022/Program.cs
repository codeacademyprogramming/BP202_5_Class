using System;

namespace _18032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elovset = new
            {
                FullName = "Elovset Abbasli",
                Age = 45,
                Gender = "Male"
            };
            var tofiq = new
            {
                Name = "Tofiq",
                Salary = 5500
            };

            Console.WriteLine(elovset.FullName);

            string text = "Hello, World!";
            int num = 45;
            double price = 45.5;
            char letter = 'A';
            bool check = false;

            string[] names = { "Hikmet", "Abdulla", "Zehra", "Tofiq" };
            string[] surnames = { "Abbasov", "Quliyev", "Abdullayeva", "Qulamov" };
            byte[] ages = { 45, 19, 34, 88 };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"FullName: {names[i]} {surnames[i]} - Age: {ages[i]}");
            }

            Human human1 = new Human
            {
                Name = "Hikmet",
                Surname = "Abbasov",
                Age = 45,
            };

            human1.Age = 55;
            human1.Gender = "Male";


            Console.WriteLine(human1.Age);

            Human human2 = new Human();

            Console.WriteLine(human2.Age);

            human2.Name = "Zehra";
            human2.Surname = "Abbasova";
            human2.Age = 38;
            
            human2.Gender = "Female";

            Console.WriteLine(human2.Age);

            Human[] humans = new Human[] { human1, human2, new Human { Name = "Tofiq", Surname = "Qulamov", Age = 88 } };

            Console.WriteLine("Humans:");
            
            foreach (var item in humans)
            {
                Console.WriteLine($"FullName: {item.GetFullName()}  - Age: {item.Age}");
            }

            Car car1 = new Car(40, 2018)
            {
                Brand = "Mercedes",
                Model = "E250",
                Millage = 45
            };


            car1.Drive(10);
            car1.Drive(15);
            car1.Drive(35);
            Console.WriteLine(car1.Millage);

            Car car2 = new Car(10,2019);

            Car car3 = new Car(150, "S500", "Mercedes");



            Student student1 = new Student("Abdulla","Qurbanov");

            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.Surname);


         

        }
    }



}
