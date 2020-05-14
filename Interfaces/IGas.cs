namespace inheritance
{
    public interface IGasPowered
    {
        string Name { get; set; }

        
        double FuelCapacity { get; set; }

        void RefuelTank ();
    }
}