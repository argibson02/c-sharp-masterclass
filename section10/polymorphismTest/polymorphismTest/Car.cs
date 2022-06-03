using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismTest
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }


        //has a relastion ship
        protected CarIDInfo carIDinfo = new CarIDInfo();
        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDinfo.IDNum = idNum;
            carIDinfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine($"Car ID is {carIDinfo.IDNum} and the owner is {carIDinfo.Owner}");
        }

        public Car()
        {

        }


        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"The horsepower is {HP} and color is {Color}.");
        }

        public virtual void Repair()
        {
            Console.WriteLine($"car was repaired.");
        }
    }
}
