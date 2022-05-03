using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstClass
{
    // class is blueprint for a datatype
    internal class Human
    {
        // member var
        public string firstName = "Pauly"; // public makes the class unprotected
                                           // string firstName; // protected. Only can be mutated from within the class
                                           // private string firstName; // protected. Only can be mutated from within the class
        private string lastName = "Dino"; // if a construor is used to make a class instance, private can be used without issue.
        private string eyeColor = "";
        private int age;

        // default constructor
        public Human()
        {
            Console.WriteLine("Constructor default. New Human created.");
        }

        // constructor
        public Human(string myFirstName)
        {
            firstName = myFirstName;
        }

        // constructor
        public Human(string myFirstName, string lastName)
        {
            firstName = myFirstName;
            this.lastName = lastName; // grabs local var
        }

        // constructor
        public Human(string myFirstName, string lastName, string eyeColor)
        {
            firstName = myFirstName;
            this.lastName = lastName; // grabs local var
            this.eyeColor = eyeColor;
        }

        // parameterized constructor
        public Human(string myFirstName, string lastName, string eyeColor, int age)
        {
            firstName = myFirstName;
            this.lastName = lastName; // grabs local var
            this.eyeColor = eyeColor;
            this.age = age;
        }



        // member method
        public void Introduce()
        {
            if (lastName.Equals("Dino"))
            {
                Console.WriteLine($"Hello, my name is {firstName}");

            }
            else if (eyeColor.Equals(""))
            {
                Console.WriteLine($"Hello, my name is {firstName} {lastName}.");

            }
            else if (age == 1)
            {
                Console.WriteLine($"Hello, my name is {firstName} {lastName}. I have {eyeColor} eyes and I am {age} year old.");
            }
            else if (age == 0)
            {
                Console.WriteLine($"Hello, my name is {firstName} {lastName}. I have {eyeColor} eyes.");
            }
            else
            {
                Console.WriteLine($"Hello, my name is {firstName} {lastName}. I have {eyeColor} eyes and I am {age} years old.");

            }

        }
    }
}
