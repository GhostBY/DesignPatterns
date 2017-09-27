using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Abstract;

namespace Factory.Entities
{
    public class Dell : Notebook
    {
        public override string Company { get; }
        public override string Model { get; set; }
        public override double Price { get; set; }
        public Dell(string Model, double Price)
        {
            Company = "DELL";
            this.Model = Model;
            this.Price = Price;
        }
    }
}
