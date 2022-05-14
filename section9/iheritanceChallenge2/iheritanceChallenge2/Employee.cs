using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iheritanceChallenge2
{
    internal class Employee
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }


        public Employee()
        {
            Name = "test test";
            FirstName = "test";
            Salary = 0;
        }


        public Employee(string name, string firstname, int salary)
        {
            this.Name = name;
            this.FirstName = firstname;
            this.Salary = salary;

        }


        public virtual void Work()
        {
            Console.WriteLine($"Employee {Name} is working. Salary is {Salary}.");
        }

        public virtual void Pause()
        {
            Console.WriteLine($"Employee {Name} has stopped working.");

        }
    }
}
