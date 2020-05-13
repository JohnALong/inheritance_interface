using System;

namespace inheritance
{
    public class Ram : Vehicle, IGasPowered
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank ()
        {
            Console.WriteLine("Holy cost point Batman!  34 gallons???");
        }

        public override void Drive()
        {
            Console.WriteLine("Rrrruuummmmbbbbllleeee!");
        }
    }
}