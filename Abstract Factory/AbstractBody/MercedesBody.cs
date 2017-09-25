using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractBody
{
    public class MercedesBody:AbstractBody
    {
        public MercedesBody(string Type, string Color, int DoorCount) : base(Type, Color, DoorCount)
        {
        }

        public void GetInfo()
        {
            base.GetInfo();
        }
    }
}
