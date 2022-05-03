using System;

namespace whileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int c = 0;

            while (c <= 10)
            {
                Console.WriteLine(c);
                c++;
            }

            int d = 1;
            Console.WriteLine("Pres enter to increment, any other key to exit.");
            string exit = "";


            while (exit.Equals(""))
            {
                exit = Console.ReadLine();

                if (exit == "")
                {
                    Console.WriteLine(d + " students");
                    d++;
                }
            }



            Console.WriteLine("done.");
            Console.ReadLine();
        }
    }
}
