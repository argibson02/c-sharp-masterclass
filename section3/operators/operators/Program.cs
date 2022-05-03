using System;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num1 = 5;
            int num2 = 3;
            int num3;

            // uninary operator
            num3 = -num1;
            Console.WriteLine($"this is num3: {num3}");

            bool isSunny = true;
            Console.WriteLine($"Is it sunny? {!isSunny}");

            // incrment operators
            int num4 = 0;
            num4++;
            Console.WriteLine($"this is num4: {num4}");
            Console.WriteLine($"this is num4: {num4++}"); // used after line. postinc
            Console.WriteLine($"this is num4: {++num4}"); // used in same line. preinc

            int num5 = 0;
            num5--;
            Console.WriteLine($"this is num5: {num5}");
            Console.WriteLine($"this is num5: {num5--}"); // used after line. postdec
            Console.WriteLine($"this is num5: {--num5}"); // used in same line. predec

            int result;
            result = num1 + num2;   
            Console.WriteLine($"results add {result}.");

            result = num1 - num2;
            Console.WriteLine($"results#2 minus {result}.");

            result = num1 * num2;
            Console.WriteLine($"results#3 divide {result}.");

            result = num1 / num2;
            Console.WriteLine($"results#4 mutip {result}.");

            result = num1 % num2;
            Console.WriteLine($"results#5 modulo {result}.");


            // relation and type operators
            bool resutsBool;
            resutsBool = num1 < num2;
            Console.WriteLine($"results#5 < {resutsBool}.");

            resutsBool = (num1 == num2);
            Console.WriteLine($"results#5 == {resutsBool}.");

            resutsBool = (num1 != num2);
            Console.WriteLine($"results#5 != {resutsBool}.");

            //conditional operator
            bool isLowerAndSunny;
            bool isLower = false;

            resutsBool = isLower && isSunny;
            Console.WriteLine($"results && {resutsBool}.");

            resutsBool = isLower || isSunny;
            Console.WriteLine($"results || {resutsBool}.");


            Console.Read();
        }
    }
}
