using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            writeSomething();
            writeAnything("hello i argument");
            Console.ReadLine();

        }




        // access modifiier, return type, method name, (param 1, param 2)  
        public static void writeSomething()
        {
            Console.WriteLine("called from my method");
            // Console.ReadLine();
        }
         
        public static void writeAnything(string myText)
        {
            Console.WriteLine(myText);
            // Console.ReadLine();

        }




    }
}
