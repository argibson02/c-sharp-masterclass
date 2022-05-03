using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiesTest
{
    internal class Box
    {
        // member vars
        private int height;
        private int length = 3;
        // public int width;
        private int volume;

        public Box(int length, int height, int width)
        {
            this.height = height;
            this.length = length;
            Width = width;
              
        }


        // shorthand get and set property
        public int Width { get; set; }

        // get and set property
        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        public int Volume
        {
            get { return this.length * this.height * this.Width; }
        }

        public int FrontSurface
        {
            get { return length * height; }
        }
        // encapsulation. Retricts the access and modification of propertis in classes

        // Setters and getter are good for error proofing property entry.
        public void SetLength(int length)
        {
            if (length <= 0)
            {
                throw new Exception("Lentgh must be a positive value.");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            volume = this.Height * this.length * this.Width;
            return volume;
        }

        public void DisplayInfo()
        {
            volume = height * length * Width;
            Console.WriteLine($"H: {Height}, L: {length}, W: {Width}, V: {volume}.");
        }



    }
}
