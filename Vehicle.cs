using System;

namespace inheritance
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive ()
        {
            Console.WriteLine("Vroooom!");
        }

        public virtual void Turn (string direction)
        {
            Console.WriteLine("The vehicle carefully turns to the right");
        }

        public virtual void Stop ()
        {
            Console.WriteLine("Hit the brakes!  We're gonna crash!");
        }
    }
}