using System;

namespace inheritance
{
    public class Zero : Vehicle, IElectricPowered
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery ()
        {
            Console.WriteLine("Zero's charge FAST!");
        }

        public override void Drive() 
        {
            Console.WriteLine("Zooooom!!!");
        }
    }
}