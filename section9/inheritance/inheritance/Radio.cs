using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Radio : ElectronicDevice // extends electronic device class
    {



        public Radio(bool isOn, string brand) : base(isOn, brand)
        { }



        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Jams are blasting!");
            }
            else
            {
                Console.WriteLine("You need to turn on the radio!");
            }
        }

    }
}
