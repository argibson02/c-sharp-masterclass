using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismTest
{
    internal class Audi : Car
    {

        private string Brand = "Audi";

        public string Model { get; set; }
        public Audi(int hp, string color, string model) : base(hp, color)
        {
            //this.HP = HP;
            this.Model = model;
            //this.Color = color;

        }

        public void ShowDetails()
        {
            Console.WriteLine($"The horsepower is {HP} and color is {Color}. Brand is {Brand}");
        }

        public override void Repair()
        {
            Console.WriteLine($"{Brand} {Model} was repaired.");
        }
    }
}


