using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractFactory
{
     public abstract class AbstractFactory
     {
         public abstract AbstractCar.AbstractCar CreateCar(AbstractBody.AbstractBody body, AbstractEngine.AbstractEngine engine, AbstractWheels.AbstractWheels wheels);
     }
}
