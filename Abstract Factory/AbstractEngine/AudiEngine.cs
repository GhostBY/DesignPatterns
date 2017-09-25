using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractEngine
{
    class AudiEngine:AbstractEngine
    {
        public AudiEngine(string Type, double Value) : base(Type, Value)
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Марка: Audi ");
            base.GetInfo();
            Console.WriteLine(@"Модификация: TFSI");
        }
    }
}
