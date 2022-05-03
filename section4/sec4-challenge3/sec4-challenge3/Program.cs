using System;

namespace sec4_challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome.");
            Entry();

            Console.ReadKey();
        }

        public static void Entry()
        {
            Console.WriteLine("Please enter in a tempurature and I will give you my opinion on it: ");
            string userEntry = Console.ReadLine();
            string test1 = string.Empty;
            if (int.TryParse(userEntry, out int temp))
            {
                string opinion = temp > 28 ? "It is too hot." : (temp <= 15 ? "It is too cold" : "The tempurature is fine.");
                Console.WriteLine(opinion);
                Console.WriteLine("Try another.\n");
                Entry();
            }
            else
            {
                Console.WriteLine("Invalid Entry.\n");
                Entry();
            }
        }
    }
}
