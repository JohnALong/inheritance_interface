using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero ();
            Tesla modelS = new Tesla ();
            Cessna mx410 = new Cessna ();
            mx410.MainColor = "yellow";

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
        }
    }
}
