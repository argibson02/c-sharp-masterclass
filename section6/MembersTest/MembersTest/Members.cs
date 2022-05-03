using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersTest
{
    internal class Members
    {
        // member private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member public field 
        public int age;

        // member property. Exposees job title safely.
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }


        // public member Method - can be called from other classes
        public void intro(bool isFriend)
        {
            if (isFriend)
            {
                sharePrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi, my name is {memberName}. My job title is {jobTitle}.");
            }
        }

        private void sharePrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 40000;
            jobTitle = "Dev";

            Console.WriteLine("Member created.");
        }

        // member - finalizer - deconstructor. Can only create 1 per class
        ~Members()
        {
            // here for cleanup. Only add if we are actually writing somehting in here.
            Console.WriteLine("deconstruction of member object.");
            Debug.Write("fdssfdsdfsdffdsfdsfds");
        }
    }
}




