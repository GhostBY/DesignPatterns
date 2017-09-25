using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractCar
{
    public class AbstractCar
    {
        public AbstractEngine.AbstractEngine Engine { get; set; }
        public  AbstractWheels.AbstractWheels Wheels { get; set; }
        public AbstractBody.AbstractBody Body { get; set; }


        public AbstractCar()
        {
            
        }
        public AbstractCar(AbstractEngine.AbstractEngine Engine, AbstractWheels.AbstractWheels Wheels, AbstractBody.AbstractBody Body)
        {
            this.Engine = Engine;
            this.Wheels = Wheels;
            this.Body = Body;
        }

        public void GetInfo()
        {
            Engine.GetInfo();
            Wheels.GetInfo();
            Body.GetInfo();
        }
    }
}
