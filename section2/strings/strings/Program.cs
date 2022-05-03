using System;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SubString32: gets substring from a string from a specificed index.
            // ex: "car", myString.SubString(2) = r
            
            // toLower()
            // toUpper()
            // Trim(): leading and trailing whitespace

             // IndexOf(myString): grabs the first occurance of a string or character inside of the string and reutrns the index number
             // isNullOrWhiteSpace: returns true if the string is either empty of is compleltey whitespace
             // 
             // StringFormat
             // 

             string firstName = "Alex";
             string lastName = "Gibson";
             string fullname = String.Concat("", firstName, lastName, " ");  
            Console.WriteLine(fullname);    
            Console.WriteLine(firstName.Substring(1));
            Console.WriteLine(firstName.IndexOf("e"));
            Console.WriteLine(String.Format("my name is {0}", firstName));   


            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
