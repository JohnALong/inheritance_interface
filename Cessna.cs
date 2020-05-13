using System;

namespace inheritance
{
    public class Cessna : Vehicle, IGasPowered
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank ()
        {
            Console.WriteLine("Takes a lot to fill a plane");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} cessna flies past and goes WWWhhhhIIIrrr!");
        }
    }
}