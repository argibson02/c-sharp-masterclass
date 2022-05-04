using System;

namespace forEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (i * 2);
                Console.WriteLine($"num {nums[i]}, indx {i}");
            }

            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!");


            int[] arr2 = new int[10];
            int counter = 0;
            foreach (int item in arr2)
            {
                Console.WriteLine($"item {item}");
                arr2[item] = (counter * 1);
                Console.WriteLine(arr2[item]);
                counter++;
            }

            string[] sunny = {"chalie", "mac", "dennis", "dee", "frank" };


            foreach (string character in sunny)
            {
                Console.WriteLine($"Hi, {character}");
            }  



            Console.Read();
        }
    }
}
