using System;

namespace propertiesTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Box box1 = new Box(3, 4, 5);
            // box1.length = 3;
            //box1.Height = -4;
            // box1.Width = 5;
            // box1.SetLength(6);


            Console.WriteLine($"box L: {box1.GetLength()}");

            Console.WriteLine(box1.FrontSurface);

            box1.DisplayInfo();



            Console.ReadKey();
        }
    }
}
