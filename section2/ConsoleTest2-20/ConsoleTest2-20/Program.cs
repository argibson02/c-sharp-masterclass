using System;

namespace ConsoleTest2_20
{
    internal class Program
    {
        // class uses PascalCase
        static void Main(string[] args)
        {
            // method uses PascalCase
            // method args use camelCase
            // local var use camelCase. don't use numbers at the beginning of var
            // avoid _ in vars


            // use these:
            // string myName;
            // int age;
            // bool isTrue;

            // not these:
            // String myName;
            // Int32 age
            // Boolean isTrue;




            // Console.Write("Hello World!");
            // prints and keeps the cursor on the same line

            // Console.WriteLine();
            // prints and keeps the cursor on the NEXT line

            // Console.Read();
            // takes a single input type of string and it returns
            // the ASCII value of that input.

            // Console.ReadLine();
            // takes string or int input and returns it as
            // the output value.

            // Console.ReadKey();
            // takes a single input of type string and returns 
            // returns the Key Info

            //Console.Write("enter in a string pls and press enter: ");
            //string inputStg = Console.ReadLine();
            //Console.WriteLine("you have entered in {0}", inputStg);

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White; //property
            Console.Clear(); // clear console buffer
            // makes the settings affect the whole console.
            Console.Write("enter in a string pls and press enter: ");
            int ascii = Console.Read();
            Console.WriteLine("acsii value of: {0}", ascii); // method
            Console.ReadKey();


        }
    }
}
