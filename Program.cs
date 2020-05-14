using System;
using System.Collections.Generic;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero ();
            fxs.Name = "fxs";
            Tesla modelS = new Tesla ();
            modelS.Name = "modelS";
            Zero fx = new Zero ();
            fx.Name = "fx";
            
            List<IElectricPowered> electricVehicles = new List<IElectricPowered>();

            electricVehicles.Add(fxs);
            electricVehicles.Add(modelS);
            electricVehicles.Add(fx);

            Ram ram = new Ram();
            ram.Name = "Ram";
            Cessna mx410 = new Cessna ();
            mx410.Name = "mx410";

            List<IGasPowered> gasVehicles = new List<IGasPowered>();
            gasVehicles.Add(ram);
            gasVehicles.Add(mx410);

            GasStation brentwoodGas = new GasStation();
            brentwoodGas.Capacity = 3;

            BatteryStation brentwoodBattery = new BatteryStation();
            brentwoodBattery.Capacity = 4;

            brentwoodBattery.Refuel(electricVehicles);
            brentwoodGas.Refuel(gasVehicles);
        }
    }
}
