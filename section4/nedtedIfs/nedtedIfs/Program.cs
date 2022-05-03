using System;

namespace nedtedIfs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";

            Console.WriteLine("Please enter in a username: ");
            userName = Console.ReadLine();

            // if(int1 == int 2) comparing ints
            // if(string.Equals("string2")) comparing strings

            if (isRegistered)
            {
                Console.WriteLine("Hi there reg user.");
                if (userName != "")
                {
                    Console.WriteLine($"G'day {userName}.");
                    if (userName.Equals("Admin"))
                    {
                        Console.WriteLine("Logged into Admin account.");
                    }
                }
            }
            
            if (isAdmin || isRegistered)
            {
                Console.WriteLine("Logging into System.");
            }
            
            
            
            
            Console.Read();
        }
    }
}
