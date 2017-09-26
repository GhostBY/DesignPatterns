using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.AbstractBody;
using AbstractFactory.AbstractCar;
using AbstractFactory.AbstractEngine;
using AbstractFactory.AbstractWheels;

namespace AbstractFactory.AbstractFactory
{
    public class BMWFactory : AbstractFactory
    {
        public override AbstractCar.AbstractCar CreateCar(AbstractBody.AbstractBody body, AbstractEngine.AbstractEngine engine, AbstractWheels.AbstractWheels wheels)
        {
            return new BMW(engine, wheels, body); ;
        }
    }
}
