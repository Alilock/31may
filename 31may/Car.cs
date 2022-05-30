using System;
using System.Collections.Generic;
using System.Text;

namespace _31may
{
    internal class Car
    {
        public int FuelCapacity; 


        public void AddFuel(int fuel)
        {
            if (fuel<FuelCapacity)
            {
                FuelCapacity += fuel;
            }
            
        }
    }



}
