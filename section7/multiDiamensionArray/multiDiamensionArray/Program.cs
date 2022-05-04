using System;

namespace multiDiamensionArray
{
    internal class Program
    {

        static int[,] arr2dX = new int[,]
        {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 2d array 
            string[,] matrix;


            // 3d array 
            int[,,] threads;

            // 2d init
            int[,] arr2d = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
            };
            Console.WriteLine("grabs 6 " + arr2d[1, 1]);

            // init 3d 
            int[,,] arr3d = new int[,,]
            {
                {
                    {1,2},
                    {3,4}
                },
                {
                    {4,5},
                    {5,6}
                }
            };
            Console.WriteLine("grabs 5 " + arr3d[1, 0, 1]);

            string[,] arr2dS = new string[3, 2]
            {
                {"ein","zwei"},
                {"drei","fier"},
                {"funf","sechs"}
            };

            arr2dS[1, 1] = "chicken";
            Console.WriteLine(arr2dS[1, 1]);

            // rank counts dimentions 
            int diamentions = arr2dS.Rank;

            // another way to init array
            int[,] arr2dB = { { 1, 2 }, { 3, 4 } };
            Console.WriteLine("~~~~~~~~~~~~~~~");

            foreach (int i in arr2dX)
            {
                Console.Write(i);
                // cannot assign i in for each loop
            }
            Console.WriteLine("@@@@@");
            for (int i = 0; i < arr2dX.GetLength(0); i++)
            {
                for (int j = 0; j < arr2dX.GetLength(1); j++)
                {
                    if (arr2dX[i, j] % 2 == 0)
                    {
                        Console.WriteLine(arr2dX[i, j] + " even");

                    }
                    else
                    {
                        Console.WriteLine(arr2dX[i, j] + " odd");

                    }
                }
            }

            for (int i = 0; i < arr2dX.GetLength(0); i++)
            {
                for (int j = 0; j < arr2dX.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(arr2dX[i, j]);

                    }
                    else
                    {
                        // Console.Write(arr2dX[i, j]);
                        Console.Write(" ");

                    }
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < arr2dX.GetLength(0); i++)
            {
                //Console.WriteLine($"{arr2dX[i, i]} TLR");
                // Console.WriteLine(arr2dX.GetLength(1));
                Console.WriteLine($"{arr2dX[i, ((arr2dX.GetLength(1) - 1) - i)]} TRL");


                //if (i == j)
                //{
                //    Console.Write(arr2dX[i,j]);

                //}
                //else
                //{
                //    Console.Write(" ");

                //}
            }

            for (int i = 0, j = 2; i < arr2dX.GetLength(0); i++, j--)
            {
                Console.WriteLine(arr2dX[i, j] + " hi");
            }

            Console.Read();
        }
    }
}
