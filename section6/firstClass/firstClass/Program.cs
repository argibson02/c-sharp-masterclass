using System;

namespace firstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // create object of my class/ instance of Human
            // Human alex = new Human();

            // access public var from outside
            // how to add without a constructor
            // alex.firstName = "Alex";
            // alex.lastName = "Gibson";

            // call methods from the class
            // alex.Introduce();

            Human bill = new Human("Billy", "The Kid", "Brown", 23);
            bill.Introduce();

            Human jj = new Human("Jesse", "James", "Green", 1);
            jj.Introduce();

            Human bozo = new Human();
            bozo.Introduce();

            Human maria = new Human("Maria", "Lopez", "brown");
            maria.Introduce();

            Human abe = new Human("Abe", "Lincoln");
            abe.Introduce();

            Human george = new Human("George");
            george.Introduce();

            Console.Read();
        }
    }
}
