using System;
using System.Collections.Generic;

namespace inheritance
{
    public class BatteryStation : IRefuelStation<IElectricPowered>
    {
        public int Capacity { get; set; }
        public void Refuel(List<IElectricPowered> ep)
        {
            foreach (IElectricPowered vehicle in ep)
            {
                Console.WriteLine($"The {vehicle.Name} charged until full.");
            }
        }
    }
}