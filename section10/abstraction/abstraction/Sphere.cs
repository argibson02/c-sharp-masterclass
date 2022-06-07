using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class Sphere : Shape
    {

        public double Diameter { get; set; }

        public Sphere(double diameter)
        {
            Name = "Sphere";
            this.Diameter = diameter;
        }
        public override double Volume()
        {
            return Math.Pow(Diameter / 2, 3) * (Math.PI * (4/3));
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"tHE CUBE HAS A volume OF {Volume()}");
        }

    }
}
