using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractWheels
{
    public class AudiWheels:AbstractWheels
    {
        public AudiWheels()
        {
            Radius = 19;
            TireName = "Goodyear";
            DiskName = "AudiWheels";
        }

        public void GetInfo()
        {
            
            base.GetInfo();
            Console.WriteLine("Марка: Audi");
        }
    }
}
