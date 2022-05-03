using System;

namespace doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int c = 0;

            do
            {
                Console.WriteLine(c);
                c++; // need something to change state, or else infinte loop
                // always does this section fefore checking the criteria.
            } while (c < 5);

            int length = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("please enter name");
                string name = Console.ReadLine();
                int curLength = name.Length;
                length += curLength;
                wholeText += name;
                Console.WriteLine($"tezt: {wholeText}. length: {length}.");
            } while (length < 20);
            Console.WriteLine("Done");





            Console.ReadKey();
        }
    }
}
