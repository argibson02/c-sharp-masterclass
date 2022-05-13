using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtuals
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.IsHungry = true;
        }

        public virtual void MakeSound() 
            // virtuals can be overwritten by classes that inerit from this class
        {
            Console.WriteLine();
        }

        public virtual void Eat()
            // virtuals can be empty, but if you put something in you can create a default behavior.
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating.");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry.");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }

    }
}
