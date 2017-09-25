using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractBody
{
    public class AudiBody:AbstractBody
    {
        public AudiBody(string Type, string Color, int DoorCount) : base(Type, Color, DoorCount)
        {
        }
        public void GetInfo()
        {
            base.GetInfo();
        }
    }
}
