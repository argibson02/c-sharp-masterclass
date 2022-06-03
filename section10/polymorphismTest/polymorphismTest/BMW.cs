using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismTest
{
    // bmw is a car
    internal class BMW:Car
    {

        private string Brand = "BMW";

        public string Model { get; set; }
        public BMW(int hp, string color, string model):base(hp, color)
        {
            //this.HP = HP;
            this.Model = model;
            //this.Color = color;
               
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"BMW The horsepower is {HP} and color is {Color}. Brand is {Brand}");
        }

        public override void Repair() //sealed closes up from futhur inhertiance
       // public sealed override void Repair() //sealed closes up from futhur inhertiance

        {
            Console.WriteLine($"{Brand} {Model} was repaired.");
        }
        // can only seal override methods
    }
}
