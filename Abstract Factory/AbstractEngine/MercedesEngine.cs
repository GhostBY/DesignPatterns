using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractEngine
{
    class MercedesEngine:AbstractEngine
    {
        public MercedesEngine(string Type, double Value) : base(Type, Value)
        {
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(@"Модификация: MB 229.5");
        }
    }
}
