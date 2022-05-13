using System;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Radio newRadio = new Radio(false, "Sony");

            newRadio.ListenRadio();
            Console.ReadKey();
            newRadio.SwitchOn();
            Console.ReadKey();
            newRadio.ListenRadio();
            Console.ReadKey();
            newRadio.SwitchOff();
            newRadio.ListenRadio();
            Console.ReadKey();
            Console.WriteLine("~~~~~~~~~~~~~~~~~");
            
            TV newTv = new TV(false, "Hitachi");
            newTv.WatchTV();
            Console.ReadKey();
            newTv.SwitchOn();
            Console.ReadKey();
            newTv.WatchTV();
            Console.ReadKey();
            newTv.SwitchOff();
            newTv.WatchTV();
            Console.ReadKey();

            Console.ReadLine();
        }
    }
}

