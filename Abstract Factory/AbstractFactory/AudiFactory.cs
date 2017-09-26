using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.AbstractCar;

namespace AbstractFactory.AbstractFactory
{
    public  class AudiFactory:AbstractFactory
    {
        public AudiFactory()
        {
            
        }
        public override AbstractCar.AbstractCar CreateCar(AbstractBody.AbstractBody body,AbstractEngine.AbstractEngine engine,AbstractWheels.AbstractWheels wheels)
        {
            return new Audi(engine,wheels,body);
        }
    }
}
