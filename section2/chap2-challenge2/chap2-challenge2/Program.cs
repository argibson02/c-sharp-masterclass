using System;

namespace chap2_challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userEntry;
            // string searchChar;
            char searchChar;


            Console.Write("Please enter a string here: ");
            userEntry = Console.ReadLine();
            userEntry = userEntry.Trim(); 

            Console.Write("Please enter a character to search for: ");
            // searchChar = Console.ReadLine();
            searchChar = Console.ReadLine()[0];


            int indexLocation = userEntry.IndexOf(searchChar);

            Console.WriteLine($"The character '{searchChar}' appeared in index {indexLocation} or the srting '{userEntry}'.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");



            string first;
            string last;

            Console.Write("Please enter in your first name: ");
            first = Console.ReadLine();

            Console.Write("Please enter in your last name: ");
            last = Console.ReadLine();

            string full = $"{first} {last}";

            Console.WriteLine($"Your full name is {full}.");

            // Console.WriteLine(userEntry.ToUpper());
            // Console.WriteLine(userEntry.ToLower());
            // Console.WriteLine(userEntry.Trim());
            // Console.WriteLine(userEntry.Substring(5));

        }
    }
}
