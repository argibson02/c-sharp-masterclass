using System;

namespace sec5_challenge1
{
    internal class Program
    {
        //Imagine you are a developer and get a job in which you need to create a program for a teacher.He needs a program written in c# that calculates the average score of his students. So he wants to be able to enter each score individually and then get the final average score once he enters -1.
        //So the tool should check if the entry is a number and should add that to the sum.Finally once he is done entering scores, the program should write onto the console what the average score is.
        //The numbers entered should only be between 0 and 20. Make sure the program doesn't crash if the teacher enters an incorrect value.
        //Test your program thoroughly.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double currentTotal = 0;
            double average = 0;
            int numOfStudents = 0;

            AddToAvg(currentTotal, average, numOfStudents);

            Console.Read();
        }

        static void AddToAvg(double currentTotal, double average, int numOfStudents)
        {
            Console.WriteLine("Enter a test score for a student (between 0 - 20), or type in 'quit' to exit the program.");
            string userEntry = Console.ReadLine();
            userEntry = userEntry.Trim().ToLower();

            if (userEntry.Equals("quit"))
            {
                Console.WriteLine("========================");
                Console.WriteLine($"FINAL cummulative score: {currentTotal}\nFINAL number of students: {numOfStudents}.\nFINAL test score average: {average}.");
            }
            else if (double.TryParse(userEntry, out double currentTestScore))
            {
                if (currentTestScore >= 0 && currentTestScore <= 20)
                {
                    numOfStudents++;
                    currentTotal += currentTestScore;
                    average = currentTotal / numOfStudents;

                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"Current cummulative score: {currentTotal}\nCurrent number of students: {numOfStudents}.\nCurrent test score average: {average}.");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
                    AddToAvg(currentTotal, average, numOfStudents);
                }
                else
                {
                    Console.WriteLine("*************************");
                    Console.WriteLine("Test score must be between 0 - 20.");
                    Console.WriteLine("*************************");
                    AddToAvg(currentTotal, average, numOfStudents);
                }
            }
            else
            {
                Console.WriteLine("*************************");
                Console.WriteLine("Input was invalid.");
                Console.WriteLine("*************************");
                AddToAvg(currentTotal, average, numOfStudents);
            }
        }
    }
}
