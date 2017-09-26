using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractCar
{
    public class BMW:AbstractCar
    {
        public  BMW(AbstractEngine.AbstractEngine Engine, AbstractWheels.AbstractWheels Wheels, AbstractBody.AbstractBody Body)
        {
            this.Engine = Engine;
            this.Wheels = Wheels;
            this.Body = Body;
        }
    }
}
