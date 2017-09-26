using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractEngine
{
    public abstract class AbstractEngine
    {
        public   string Type { get; set; }
        public double Value { get; set; }

        public  AbstractEngine(string Type, double Value)
        {
            this.Type = Type;
            this.Value = Value;
        }

        public AbstractEngine()
        {
            
        }

        public virtual void GetInfo()
        {
            Console.WriteLine(@"Тип: {0} ",Type);
            Console.WriteLine(@"Объем: {0} ", Value);
        }
    }
}
