using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractWheels
{
    public class MercedesWheels:AbstractWheels
    {
        public MercedesWheels()
        {
            Radius = 19;
            TireName = "Michelin";
            DiskName = "MercedesWheels";
        }

        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Марка: Audi");
        }
    }
}
