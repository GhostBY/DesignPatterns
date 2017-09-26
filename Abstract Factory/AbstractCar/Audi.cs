using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractCar
{
    public class Audi:AbstractCar
    {
        public  Audi(AbstractEngine.AbstractEngine Engine, AbstractWheels.AbstractWheels Wheels, AbstractBody.AbstractBody Body)
        {
            this.Engine = Engine;
            this.Wheels = Wheels;
            this.Body = Body;
        }

    }
}
