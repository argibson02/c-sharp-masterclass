using System;

namespace paramsTest
{
    internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
            int price= 45;
            float pi = 3.14f;
            char at = '@';
            string book = "hobbit";





        ParamsMethod("this", "is", "a", "long", "string");
        ParamsMethod2(price, pi, at, book);



            Console.WriteLine(MyMin(1,2,3,4,5,-6,22,4,555,62,2,4,7,4));

        Console.Read();
    }

    public static void ParamsMethod(params string[] sentence)
    {
        for (int i = 0; i < sentence.Length; i++)
        {
            if (i < sentence.Length - 1)
            {
                Console.Write(sentence[i] + " ");
            }
            else
            {
                Console.Write(sentence[i]+".");
            }
        }
    }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object stuffObj in stuff)
            {
                Console.WriteLine(stuffObj+" ");
            }
        }


        public static int MyMin(params int[] arr)
        {
            int min = int.MaxValue;

            foreach (int item in arr)
            {
                if(item< min)
                {
                    min = item;
                }
            }

            return min;
        }



    }
}
