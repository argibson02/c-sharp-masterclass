using System;

namespace arraysStart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] grades = new int[5];

            // assigning values to indexes
            grades[0] = 20;
            grades[1] = 4;
            grades[2] = 5;
            grades[3] = 6;
            grades[4] = 7;


            Console.WriteLine($" indx 0: {grades[0]}");

            // init array type 2
            int[] gradesStudents = { 33, 44, 22, 44, 23 };

            // int array type 3
            int[] gradesB = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine($"{gradesB.Length}");
            Console.ReadKey();

        }
    }
}
