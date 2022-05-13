﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class TV : ElectronicDevice
    {

        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }


        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Tv is on!");
            }
            else
            {
                Console.WriteLine("You need to turn on the tv!");
            }
        }

    }
}
