using System;

namespace tryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string numberAsString = "";
            int parseValue;
            bool success = int.TryParse(numberAsString, out parseValue);    
            // try parse exists on many different data types

            if (success)
            {
                Console.WriteLine($"Parse success: {parseValue}");
            } else
            {
                Console.WriteLine("failed to parse");
            }

            // string age = "11" passes parse
            // string age = "11sdffsdsdfs" fails parse



        }
    }
}
