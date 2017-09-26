using System;
using AbstractFactory. AbstractEngine;
using System.Text;
using AbstractFactory.AbstractBody;
using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractWheels;

namespace AbstractFactory
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //AbstractEngine bmwEngine = new BMWEngine("Diesel",3.0);
            //bmwEngine.GetInfo();
            //AbstractEngine audiEngine = new AudiEngine("Diesel", 2.0);
            //audiEngine.GetInfo();
            //AbstractEngine MBngine = new MercedesEngine("Diesel", 3.2);
            //MBngine.GetInfo();
            AbstractEngine.AbstractEngine audiEngine = new AudiEngine("Diesel", 2.0);
            AbstractBody.AudiBody audiBody = new AudiBody("Universal","Red",5);
            AbstractWheels.AbstractWheels audiWheels = new AudiWheels();
            AbstractFactory.AbstractFactory audiFactory = new AudiFactory();
            AbstractCar.AbstractCar audi = audiFactory.CreateCar(audiBody, audiEngine, audiWheels);
            audi.GetInfo();
           Console.ReadLine();
        }
    }
}
