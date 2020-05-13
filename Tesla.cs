using System;

namespace inheritance
{
    public class Tesla : Vehicle, IElectricPowered
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery ()
        {
            Console.WriteLine("Tesla's charge slow, but last forever!");
        }

        public override void Drive() 
        {
            Console.WriteLine("HHHHHuuuumMMMM!!!!!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine("The cessna banks to the left!");
        }

        public override void Stop()
        {
            Console.WriteLine("The cessna bumps down the runway");
        }
    }
}