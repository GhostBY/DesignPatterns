using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractFactory
{
     public abstract class AbstractFactory
     {
         public abstract AbstractEngine.AbstractEngine CreateEngine();
     }
}
