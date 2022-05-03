using System;

namespace sec4_challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a user Login System, where the user can first register and then Login in. The Program should check if the user has entered the correct username and password,
            // wenn login in (so the same ones that he used when registering).
            //As we haven't covered storing data yet, just create the program in a way, that registering and logging in, happen in the same execution of it.
            //User If statements and User Input and Methods to solve the challenge.

            Console.WriteLine("Hello. Please register and enter in your username:");
            string username = Console.ReadLine();
            Console.WriteLine("Plaese enter in a password:");
            string password = Console.ReadLine();
            
            Console.WriteLine("~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Hello, {username}. You are now logged in.");
            Console.ReadKey();
            Console.WriteLine("Loggin you out.");
            Console.WriteLine("~~~~~~~~~~~~~~~~");
            Console.ReadKey();

            Console.WriteLine("Hello again. Please enter in a username:");
            string un2 = Console.ReadLine();    
            
            if (!(un2.Equals(username)))
            {
                Console.WriteLine("Sorry, that is not the correct user.");
                Console.ReadKey();
                return;
            }


            Console.WriteLine("Please enter in a password:");
            string pw2 = Console.ReadLine();

            if (!(pw2.Equals(password)))
            {
                Console.WriteLine("Sorry, that is not the correct password.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Successfully re-logged in.");

            Console.Read();








        }
    }
}
