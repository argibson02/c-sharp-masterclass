using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iheritanceChallenge2
{
    internal class Trainee : Employee
    {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }


        public Trainee(string name, string firstname, int salary, int workinghours, int schoolhours) : base(name, firstname, salary)
        {
            this.WorkingHours = workinghours;
            this.SchoolHours = schoolhours;
        }

        public virtual void Learn()
        {
            Console.WriteLine($"Trainee {Name} is learing. {FirstName}'s learning hours are {SchoolHours}.");
        }

        public override void Work()
        {
            Console.WriteLine($"Employee {Name} is working. {FirstName}'s working hours are {WorkingHours}. Salary is {Salary}");
        }


    }
}
