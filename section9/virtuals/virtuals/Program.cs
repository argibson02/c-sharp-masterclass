using System;

namespace virtuals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dog dog = new Dog("Doug", 12);

            dog.Play();
            dog.Eat();
            dog.MakeSound();

            Console.ReadLine();
        }
    }
}
