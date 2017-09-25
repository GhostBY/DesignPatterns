using System;
using AbstractFactory.AbstractEngine;
using System.Text;

namespace Abstract_Factory
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            AbstractEngine bmwEngine = new BMWEngine("Diesel",3.0);
            bmwEngine.GetInfo();
            AbstractEngine audiEngine = new AudiEngine("Diesel", 2.0);
            audiEngine.GetInfo();
            AbstractEngine MBngine = new MercedesEngine("Diesel", 3.2);
            MBngine.GetInfo();
            Console.ReadLine();
        }
    }
}
