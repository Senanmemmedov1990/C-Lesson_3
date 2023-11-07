using System;

namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Senan", "Memmedov", 33);

            Console.WriteLine(person.isAdult);

            var masin = new Car("KIA", "Sorento", 2013, "Diesel", "Boz");
            masin.PrintInfo();

        }
        

    }
 
    //Task - 1
      


    public class Person
    {
        public string Name;
        public string SurName;
        public byte Age;
        public bool isAdult;

        public Person(string name, string surName, byte age)
        {
            Name = name;
            SurName = surName;
            Age = age;
            isAdult = age > 18 ? true : false;
        }
    }
    //Task - 2 
    //  Brend,Model,İl,FuelType və Rəng property-ləri olan Car klasınız olsun
    //  Object yarananda Brend, Model, FuelType, İl və Rəng attributlarını ötürün.
    //  Objectdə PrintInfo Metodunuz olsun onu call edən zaman bütün məlumatları ekrana çap etsin



     public class Car
    {
        public Car() { }
        public Car(string brend, string model, int year, string fuelType, string color)
        {
            Brend = brend;
            Model = model;
            Year = year;
            FuelType = fuelType;
            Color = color;
        }

        public string Brend;
        public string Model;
        public int Year;
        public string FuelType;
        public string Color;
        

        public void PrintInfo()
        {
            Console.WriteLine($"Brend {Brend} Model { Model } Year { Year } FuelType { FuelType } Color { Color }");
        }
    }
    
}
