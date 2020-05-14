namespace inheritance
{
    public interface IElectricPowered
    {
        string Name { get; set; }

        double BatteryKWh { get; set; }

        void ChargeBattery ();
    }
}