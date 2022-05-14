using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iheritanceChallenge2
{
    internal class Manager : Employee
    {
        protected string CompanyCar { get; set; }

        public Manager(string name, string firstname, int salary, string companycar) : base(name, firstname, salary)
        {
            this.CompanyCar = companycar;
        }

        public virtual void Lead()
        {
            Console.WriteLine($"Manager {Name} is leading. {FirstName}'s company car is a {CompanyCar}.");
        }

    }
}
