using System;
using System.Text.RegularExpressions;

namespace sec7_challenge1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            loopApp();

            Console.Read();
        }

        static public void loopApp()
        {
            Console.WriteLine("Please enter in a value: ");
            string userVal = Console.ReadLine();

            Console.WriteLine("Please enter in the data type for that value. Press '1' for String, '2' for Intiger, and '3' Boolean.");
            string stringUserValType = Console.ReadLine();
            // int intValType = 0;

            if (int.TryParse(stringUserValType, out int intValType)){
                if (!(intValType == 1 || intValType == 2 | intValType ==3 )){
                    Console.WriteLine("~~~~~~~~~~~");
                    Console.WriteLine("You did not enter in a valid data type selection.");
                    Console.WriteLine("~~~~~~~~~~~");
                    loopApp();
                }
            }

            switch (intValType)
            {
                case 1:
                    bool allAlpha = true;
                    foreach (char character in userVal)
                    {
                        string hold = character.ToString();
                        if (!(Regex.IsMatch(hold, @"^[a-zA-Z]+$")))
                        {
                            allAlpha = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (allAlpha)
                    {
                        Console.WriteLine($"Yes, {userVal} was all alphabetical characters.");
                    }
                    else
                    {
                        Console.WriteLine($"No, {userVal} was not all alphabetical characters.");
                    }
                    break;


                case 2:
                    if (int.TryParse(userVal, out int rez))
                    {
                        Console.WriteLine($"Yes, {rez} was an interger.");
                    }
                    else
                    {
                        Console.WriteLine($"No, {userVal} was not an integer");
                    }
                    break;

                case 3:
                    if (userVal.Trim().ToLower().Equals("true") || userVal.Trim().ToLower().Equals("false"))
                    {
                        Console.WriteLine($"Yes, {userVal} was a boolean.");
                    }
                    else
                    {
                        Console.WriteLine($"No, {userVal} was not a boolean.");
                    }
                    break;

                default:
                    Console.WriteLine("What did you do?????");
                    break;
            }

            Console.WriteLine("++++++++++++++++++++++++++++\n");
            loopApp();

        }
    }
}


/*
Create an application that takes 2 input values.

Any input value (1st input)

Asks the data type of the input value. (2nd input)

It will print to the console the options like below to take input for the 2nd input value:

Press 1 for String

Press 2 for integer

Press 3 for Boolean

If the input value for the 2nd input is 1 then the application should check that if the entered 1st input is a valid string or not. Hereby we even want to check, if it is a complete alphabetic entry (so no numbers accepted)

If the input value for the 2nd input is 2 then the application should check if the entered 1st input is a valid integer or not.

Based on the input the 1st value and the selection of data type using the 2nd input, the application should return whether the entered 1st value is of data type selected by the user or not.

Please make sure to use a switch statement. To check the valid string you can write your custom logic.
*/