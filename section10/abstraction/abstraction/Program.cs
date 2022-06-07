using System;

namespace abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sphere s1 = new Sphere(4.21);
            s1.GetInfo();


            Shape[] shapes = { new Sphere(4), new Cube(9) };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"{shape.Name} has a volume of {shape.Volume()}");
                Cube iceCube = shape as Cube;

                if (iceCube == null)
                {
                    Console.WriteLine("This shape is not a cube.");
                } 

                if(shape is Cube) // checks type
                {
                    Console.WriteLine("This shape is a cube.");
                }



                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine($"{cube2.Name} has a v of {cube2.Volume()}");

            }


        }
    }
}
