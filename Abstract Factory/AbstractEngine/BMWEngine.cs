using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractEngine
{
    class BMWEngine : AbstractEngine
    {
        public BMWEngine(string Type, double Value) : base(Type, Value)
        {
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(@"Модификация: M62");
        }
    }
}
