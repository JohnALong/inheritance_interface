using System;
using System.Collections.Generic;

namespace inheritance
{
    public class GasStation : IRefuelStation<IGasPowered>
    {
        public int Capacity { get; set; }
        public void Refuel(List<IGasPowered> gp)
        {
            foreach (IGasPowered vehicle in gp)
            {
                Console.WriteLine($"The {vehicle.Name} put in $50 worth.");
            }
        }
    }
}