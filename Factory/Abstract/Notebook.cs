﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Abstract
{
   public abstract class Notebook
    {
        public abstract  string Company { get; }
        public abstract string Model { get; set; }
        public abstract double Price { get; set; }

        public void GetInfo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(@"Производитель: {0}", Company);
            Console.WriteLine(@"Модель: {0}", Model);
            Console.WriteLine(@"Цена: {0}", Price);
        }

    }
}
