using System;

namespace chap2_challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userEntry;

            Console.Write("Please enter your name and press enter: ");
            userEntry = Console.ReadLine();


            Console.WriteLine(userEntry.ToUpper());
            Console.WriteLine(userEntry.ToLower());
            Console.WriteLine(userEntry.Trim());
            Console.WriteLine(userEntry.Substring(5));



        }
    }
}
