using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtuals
{
    internal class Dog : Animal
    {

        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }


        // simple overridewith no change to behvaior
        public override void Eat()
        {
            base.Eat(); 
        }

        // simple ovveride with new behavior
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        public override void Play()
        {

            if (IsHappy)
            {
                base.Play();
            }
            else
            {
                Console.WriteLine("Dog is too sad to play.");
            }
        }
    }
}
