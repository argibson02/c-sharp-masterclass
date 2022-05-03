using System;

namespace methodUseInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //Console.WriteLine(input);



            //   Console.WriteLine(Add());
            double rez = tryDivide(); 

            Console.ReadLine();
        }

        public static double Add()
        {
            Console.WriteLine("Welcome to the Add method.");

            Console.WriteLine("Please enter your first number to add: ");
            string StringInput1 = Console.ReadLine();
            double IntInput1 = Double.Parse(StringInput1);

            Console.WriteLine("Please enter your second number to add: ");
            string StringInput2 = Console.ReadLine();
            double IntInput2 = Double.Parse(StringInput2);

            Console.WriteLine("Your result is:");
            return IntInput1 + IntInput2; 
        }


        public static double tryDivide()
        {
            Console.WriteLine("Welcome to TRY add. \n Please enter in a number: ");
            string StringInput1 = Console.ReadLine();
            double DoubleInput1 = 1 ;

            try
            {
                DoubleInput1 = Double.Parse(StringInput1);
            }
            catch (FormatException)
            {
            } finally
            {
                Console.WriteLine("This is finally block");
            }

            Console.WriteLine("Please enter in a second number: ");
            string StringInput2 = Console.ReadLine();
            double DoubleInput2 = 1;

            try
            {
                DoubleInput2 = Double.Parse(StringInput2);

            }
            catch (Exception)
            {
                Console.WriteLine("Format excetion. Please enter in a number."); ;
            }


            double result = 1;
            try
            {
                result = DoubleInput1 / DoubleInput2;
            }
            catch (Exception)
            {
                Console.WriteLine("something bad happened.");
            }


            Console.Read(result); 
            return result;
            //return DoubleInput1 + DoubleInput2;
        }


    }
}
