namespace inheritance
{
    public interface IGasPowered
    {
        double FuelCapacity { get; set; }

        void RefuelTank ();
    }
}