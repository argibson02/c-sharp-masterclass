using System;

namespace ImplicientConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicient conversion 
            int num = 123465789;
            long bigNum = num;

            float myFloat = 13.37f;
            double myDouble2 = myFloat;
            
            double myDouble = 13.37;
            int myInt;
            // cast db into int
            myInt = (int)myDouble;
            // explicit conversion. changes 13.37 into 13. cut off, not round


            //type conversion
            string myString = myDouble.ToString(); //"13.37"
            string myString2 = myFloat.ToString();
            bool myBool = false;
            string myString3 = myBool.ToString();

            Console.WriteLine(myInt);
            Console.WriteLine(myString);
            Console.WriteLine(myBool);




            string myString4 = "15a";
            string myString5 = "13";
            int myInt2 = Int32.Parse(myString4);
            int myInt3 = Int32.Parse(myString5);
            //int myDouble3 = Double.Parse(myString5);



            string resolved = myString4 + myString5;
            int resolved2 = myInt2 + myInt3;





            Console.WriteLine(resolved2);










            Console.Read();

        }
    }
}
