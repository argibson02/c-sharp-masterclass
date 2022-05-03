using System;

namespace stringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 21;
            string name = "Alex";
            int age2 = 33;
            string name2 = "Fred";
            int age3 = 73;
            string name3 = "Kate";

            // #1: string concatination 
            Console.WriteLine("string concat");
            Console.WriteLine("hello my name is " + name + " and I am " + age + " years old.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            // #2 string formatting. Badddddddd
            Console.WriteLine("string formatting");
            Console.WriteLine("hello my name is {0} and I am {1} years old.", name2, age2);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");

            // #3 string  interpolation
            Console.WriteLine("string interpolation");
            Console.WriteLine($"hello my name is {name3} and I am {age3} years old.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");

            // #4 verbatim string  
            Console.WriteLine("verbatim string  ");
            Console.WriteLine(@"hello my name is {name3} and I am {age3} years old.
            wfsdfsdafsdasdfaasdf
            asdfdfasdsfadfsa
            asdfdfsasdfadsf
            
            
            adfsadfsadfsadfs
            adsfadfsdfassdaf");
            Console.WriteLine(@"www.test.com\ffdfds\sdfsd\sdfsdwe\wewewefds\gfgdfggd.png");


            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");



            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
