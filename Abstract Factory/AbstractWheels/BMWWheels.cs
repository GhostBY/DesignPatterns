using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractWheels
{
    public class BMWWheels:AbstractWheels
    {
        public BMWWheels()
        {
            Radius = 19;
            TireName = "Continental";
            DiskName = "BMWWheels";
        }

        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Марка: Audi");
        }
    }
}
