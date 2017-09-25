using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractBody
{
    public class AbstractBody
    {
        public  string Type { get; set; }
        public  string Color { get; set; }
        public int DoorCount { get; set; }

        public AbstractBody()
        {
            
        }
        public AbstractBody(string Type, string Color, int DoorCount)
        {
            this.Type = Type;
            this.Color = Color;
            this.DoorCount = DoorCount;
        }

        public void GetInfo()
        {
            Console.WriteLine(@"Тип: {0} ", Type);
            Console.WriteLine(@"Цвет: {0} ", Color);
            Console.WriteLine(@"Количество дверей: {0} ", DoorCount);
        }
    }
}
