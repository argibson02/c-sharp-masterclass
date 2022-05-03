using System;

namespace MethodReturns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(3, 8);
            int result2 = Add(Add(4, 4), Add(6, 6));
            double result3 = Multiple(3.32, 9.45);
            double result4 = Divide(3.32, 9.45);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(Add(7, 7));
            Console.ReadLine();

        }

        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public static double Multiple(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double Divide(double n1, double n2)
        {
            return n1 / n2;
        }

    }
}
