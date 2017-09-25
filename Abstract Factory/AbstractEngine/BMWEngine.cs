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
            Console.WriteLine("------------------------");
            Console.WriteLine("Марка: BMW ");
            base.GetInfo();
            Console.WriteLine(@"Модификация: M62");
        }
    }
}
