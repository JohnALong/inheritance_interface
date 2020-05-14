using System;
using System.Collections.Generic;

namespace inheritance
{
    public interface IRefuelStation<T>
    {
       int Capacity { get; set; } 
       void Refuel(List<T> vehicles);
    }
}