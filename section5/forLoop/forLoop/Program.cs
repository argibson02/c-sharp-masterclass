using System;

namespace forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("~~~~~~~~~~~~~~");

            for (int i = 0; i <= 50; i += 5)
            {
                Console.WriteLine(i);

            }


            Console.WriteLine("~~~~~~~~~~~~~~");


            for (int i = 1; i <= 20; i += 2)
            {
                Console.WriteLine(i);

            }

            Console.ReadKey();
        }
    }
}
