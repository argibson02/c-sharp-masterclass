using System;

namespace sec3_challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string friend1 = "Frank";
             string friend2 = "Dennis";
            string friend3 = "Mac";
            Greet(friend1);
            Greet(friend2);
            Greet(friend3);

            Console.ReadLine();
        }

        public static void Greet(string f1)
        {
            Console.WriteLine($"Hello {f1}, my friend.");
        }
    }
}
