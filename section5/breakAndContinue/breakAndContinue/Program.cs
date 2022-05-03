using System;

namespace breakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < 10; i++)
            {

                if (i == 7)
                {
                    Console.WriteLine("Stop at 7");
                    Console.WriteLine($"{i}");
                    break; // stops for looop at this point
                }

                if (i %2 == 0)
                {
                    Console.WriteLine($"{i}");
                    continue; // jumps out of the code for this iterate at this point.
                }
                Console.WriteLine("skip 2");
            }





            Console.Read();
        }
    }
}
