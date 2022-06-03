using System;
using System.Collections.Generic;

namespace polymorphismTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var cars = new List<Car>
            {
                new Audi(150, "blue", "A4"),
                new BMW(250, "blue", "AFast"),

            };


            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmw2 = new BMW(300, "black", "z3");
            Car audi2 = new Audi(111, "white", "a3");
            bmw2.ShowDetails();
            audi2.ShowDetails();

            BMW bmw3 = new BMW(222, "red", "zz"); // uses type of car
            bmw3.ShowDetails();

            Car car2 = (Car)bmw3; // recasts bmw to generic car type.
            car2.ShowDetails();


            M3 myM3 = new M3(260, "red", "trubo");
            myM3.Repair();


            bmw2.SetCarIDInfo(123, "Alex");
            bmw2.GetCarIDInfo();


            Console.ReadKey();
        }
    }
}
