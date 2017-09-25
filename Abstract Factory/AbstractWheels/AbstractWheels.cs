using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractWheels
{
    public abstract class AbstractWheels
    {
        public int Radius { get; set; }
        public  string DiskName { get; set; }
        public  string TireName { get; set; }

        public AbstractWheels(int Radius, string DiskName, string TireName)
        {
            this.Radius = Radius;
            this.DiskName = DiskName;
            this.TireName = TireName;
        }

        public AbstractWheels()
        {
            
        }
        public void GetInfo()
        {
            Console.WriteLine(@"Информация о колесах: ");
            Console.WriteLine(@"Радиус: {0} ", Radius);
            Console.WriteLine(@"Производитель дисков: {0} ", DiskName);
            Console.WriteLine(@"Производитель покрышек: {0} ", TireName);
        }
    }
}
