using System;

namespace arrayParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] grades = new int[] { 12, 43, 21, 23, 77, 33, 54, 43, 22 };

            foreach (var item in grades)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(GetArray(grades));

            int[] happiness = new int[] { 1, 2, 3, 4, 5 };


            foreach (var item in happiness)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("!~~~~~~~~~~~~~~");
            wawa(happiness);

            foreach (var item in happiness)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(">PARAMS<");










            Console.Read();
        }



        static double GetArray(int[] gradesArr)
        {
            int size = gradesArr.Length;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArr[i];
            }

            double average = (double)sum / size;

            return average;
        }



        static void wawa(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 2;
            }
        }






    }

}
