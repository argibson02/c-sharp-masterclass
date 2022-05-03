using System;

namespace ifsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in the temp: !");
            string stringTemp = Console.ReadLine();
            int temp;

            try
            {
                if (int.TryParse(stringTemp, out int tempReading))
                {
                    temp = tempReading;
                }
                else
                {
                    temp = 20;
                    Console.WriteLine("value entered was not a number");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("you entered in soimething bad");
                throw;
            }


            bool isRaining;
            Console.WriteLine("Is it raining?: ");
            string StringRain = Console.ReadLine();

            try
            {
                isRaining = bool.Parse(StringRain);
            }
            catch (Exception)
            {
                Console.WriteLine("you entered in soimething bad");
                throw;
            }


            if (temp == 10)
            {
                Console.WriteLine("the temp is 10 c");
            }
            else if (temp > 10 && !isRaining)
            {
                Console.WriteLine("no jacket is needed");
            }
            else if (temp > 10 && isRaining)
            {
                Console.WriteLine("bring your raincoat");
            }
            else
            {
                Console.WriteLine("it is cold outside.");
            }









            Console.ReadLine();
        }
    }
}
