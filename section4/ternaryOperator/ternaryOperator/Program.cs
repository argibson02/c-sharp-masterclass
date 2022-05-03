using System;

namespace ternaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // condition ? first_expression : seconf_expression
            // condition must be TRUe or FALSE
            // The conditional operator is right - associative
            // The Expression a ? b: c? d :e
            // is evalutaed a ? b : (c ? d : e)
            // not as (a? b :c) ? d : e
            // 
            // The conditional operator cannot be overloaded
            // 
            // 

            int temp = 85;
            string stateOfMatter;

            if(temp <= 0)
            {
                stateOfMatter = "solid";
            } else if (temp >= 100)
            {
                stateOfMatter = "gas";
            } else
            {
                stateOfMatter = "liquid";
            }

            string stateOfMatterI2;
            stateOfMatterI2 = temp > 184 ? "gas" : "solid";

            string stateOfMatter3 = temp >= 100 ? "gas" : (temp <= 0 ? "solid" : "liquid");


            Console.WriteLine($"State of Matter for H20 is {stateOfMatter}.");
            Console.WriteLine($"State of Matter for I2 is {stateOfMatterI2}.");
            Console.WriteLine($"(ternary)State of Matter for H20 is {stateOfMatter3}.");
            Console.ReadKey(); 

        }
    }
}
