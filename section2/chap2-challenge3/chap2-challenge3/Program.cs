using System;

namespace chap2_challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 230;
            sbyte mySbyte = 120;
            int myInt = 69432978;
            uint myUInt = 432424;
            short myShort = -32433;
            ushort myUShort = 44324;
            long myLong = -54554334534534;
            ulong myULong = 543534534534543;
            float myFloat = 3.4565435f;
            double myDouble = 1.65355635;
            char myChar = 'f';
            string myString = "I control text";
            string myString2 = "32";
            sbyte myInt2 = SByte.Parse(myString2);
            decimal myDecimal = 2.3444444444444444m;


            Console.WriteLine(myByte);
            Console.WriteLine(mySbyte);
            Console.WriteLine(myInt);
            Console.WriteLine(myUInt);
            Console.WriteLine(myShort);
            Console.WriteLine(myUShort);
            Console.WriteLine(myLong);
            Console.WriteLine(myULong);
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myChar);
            Console.WriteLine(myString);
            Console.WriteLine(myString2);
            Console.WriteLine(myInt2);
            Console.WriteLine(myDecimal);
            Console.Read();




        }
    }
}
