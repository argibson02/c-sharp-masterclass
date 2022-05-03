using System;

namespace TypesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            //declare. Int is only for whole numbers

            num1 = 3;
            //assign

            // concatination
            int num2 = 4;
            num2 = 100;
            int sum = num1 + num2;
            Console.WriteLine("num1 "+ num1 + " num2 " +num2 + " is "+ sum);
            
            //declaring mulitple vars at once
            int num3, num4, num5;

            double db1 = 3.1415;
            double db2 = 5.1;
            double dDiv = db1 / db2;
            // 15-17 decimal points

            Console.WriteLine("double: "+ dDiv);
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            // 6-9 decimal points. less memory

            Console.WriteLine("float: "+ fDiv);

            long myLongNum = 345678345678987654;
            Console.WriteLine(myLongNum);


            double dIDiv = db1 / num1;
            // ok because this was declared as a double. Uses the most precise type.

            // int iIDiv = db1 / num1;
            // bad becuase type if of lessor.

            decimal dec = 2.22222233333333333333332222222m;
            // 28-19 decimal digits




            Console.WriteLine("DIDiv: "+dIDiv);
            // Console.WriteLine("iIDiv: " + iIDiv);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            string myName = "Alex";
            string myDesc = "my name is ";

            string caps = myDesc.ToUpper();
            string low = myName.ToLower();
            Console.WriteLine(myName);
            Console.WriteLine(caps + low);
 


            // value type is a data type that when delcard
            //and assigned a value, holds that value direclty in 
            // it's own memory space.
            // ex: int, float, long, double, char, bool, decimal etc.
            // stored in RAM.

            // referanece type is a data type that instead of storigng
            // the value in memeory directly, it stores the memory 
            // location of the actual data.
            // ex: string, class, array, etc
            // copies the memory address of the data.
            // variable access address (ususally simple) to
            // look at actuall value (can be complex).
            // two RAM locations


            Console.Read();


        }
    }
}
