using System;

namespace switchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 22;

            switch (age)
            {
                case 15:
                    Console.WriteLine("too young to enter club");
                    break;
                case 25:
                    Console.WriteLine("ok to enter");
                    break;
                default:
                    Console.WriteLine("idc, go in.");
                    break;
            }


            if (age == 15)
            {
                Console.WriteLine("too young to enter club");
            }
            else if (age == 25)
            {
                Console.WriteLine("ok to enter");
            }
            else
            {
                Console.WriteLine("idc, go in.");
            }


            string username = "root";
            switch (username)
            {
                case "alex":
                    Console.WriteLine($"hi there {username}");
                    break;
                case "root":
                    Console.WriteLine("Root user");
                    break;
                default:
                    Console.WriteLine("who are you ?????");
                    break;
            }


            Console.Read();
        }
    }
}
