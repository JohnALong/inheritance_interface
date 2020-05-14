using System;
using System.Collections.Generic;

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

        public List<Ram> rams = new List<Ram>();

        
    }
}