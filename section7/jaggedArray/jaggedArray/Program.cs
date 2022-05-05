using System;

namespace jaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // declare jagged array 
            int[][] jaggedArr = new int[3][];

            jaggedArr[0] = new int[5];
            jaggedArr[1] = new int[3];
            jaggedArr[2] = new int[2];

            jaggedArr[0] = new int[] { 1, 3, 5, 7, 11 };
            jaggedArr[1] = new[] { 1, 2, 3 };
            jaggedArr[2] = new[] { 13, 21 };


            // alternative
            int[][] jaggedArr2 = new int[][]
            {
                new int[] {1,2,3, 4,5},
                new int[] {7,8,9 },
                new int[] {9,10,11}
            };

            Console.WriteLine(jaggedArr2[0][2] + "grabs '3'");


            for (int i = 0; i < jaggedArr2.Length; i++)
            {
                for (int j = 0; j < jaggedArr2[i].Length; j++)
                {
                    Console.WriteLine(jaggedArr2[i][j]);
                }
            }



            string[][] jaggedArr3 = new string[][]
{
                new string[] {"Homer", "Marge", "Lisa"},
                new string[] {"Ned", "Maude", "Todd"},
                new string[] {"Kirk", "Luann", "Milhouse"},
};

            int count = 0;
            for (int i = 0; i < jaggedArr3.Length; i++)
            {
                for (int j = 0; j < jaggedArr3[i].Length; j++)
                {
                    //Console.WriteLine($"[{jaggedArr3[i][j]}]");
                    string currentCharacter = jaggedArr3[i][j];

                    if (i >= jaggedArr3[i].Length - 1)
                    {

                        for (int k = 0; k < jaggedArr3.Length - 1; k++)
                        {
                            for (int c = 0; c < jaggedArr3[c].Length; c++)
                            {
                                count++;
                                Console.WriteLine($"{currentCharacter}, this is {jaggedArr3[k][c]}.");
                            }
                        }
                    }
                    else
                    {
                        for (int k = i+1; k < jaggedArr3.Length; k++)
                        {
                            for (int c = 0; c < jaggedArr3[i].Length; c++)
                            {
                                Console.WriteLine("k "+k);
                                Console.WriteLine("c "+c);
                                Console.WriteLine("lentgh "+ jaggedArr3[c].Length);
                                count++;
                                Console.WriteLine($"{currentCharacter}, this is {jaggedArr3[k][c]}.");
                            }
                        }
                    }

                }
            }
            Console.WriteLine(count);

        }
    }
}
