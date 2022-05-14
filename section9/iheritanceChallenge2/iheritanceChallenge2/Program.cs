using System;

namespace iheritanceChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee fry = new Employee("Philip J Fry", "Fry", 40000);
            Manager professor = new Manager("Hubert Farnsworth", "Professor", 990000, "Mom Corp Starship");
            Trainee cubert = new Trainee("Cubert Farnsworth", "Cubert", 220000, 8, 9);
            fry.Work();
            professor.Work();
            cubert.Work();
            fry.Pause();
            professor.Pause();
            cubert.Pause();
            professor.Lead();
            cubert.Learn();

            Console.ReadLine();
        }
    }
}


/*
 Create a main class with the Main Method, then a base class Employee with the properties Name, FirstName, Salary, and the methods Work() and Pause().

Create a deriving class boss with the property CompanyCar and the method Lead().  Create another deriving class of employees - trainees with the properties 
WorkingHours and SchoolHours and a method Learn().

Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.

Don’t forget to create constructors.

Create an object of each of the three classes (with arbitrary values)

and call the methods, Lead() of Boss and Work() of Trainee.

Just print out the respective text, what the respective employees do.
E.g. Lead() should print out something like. I'm leading. It is up to you what you print out.
 */
