using System;

namespace constants
{
    internal class Program
    {
        // fields, variables outside of the methods
        const double pi = 3.1415;
        const int weeks = 52, months = 12;
        const string birthday = "1/31/2000";
        // const int days = 365;
        static void Main(string[] args)
        {
            // constants
            Console.WriteLine($"my birthdya will always be {birthday}.");
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
