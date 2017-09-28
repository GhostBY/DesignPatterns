using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Abstract;

namespace Factory.Entities
{
    public class HP:Notebook
    {
        public override string Company { get; }
        public override string Model { get; set; }
        public override double Price { get; set; }

        public HP(string Model,double Price)
        {
            Company = "HP";
            this.Model = Model;
            this.Price = Price;
        }
        public void GetInfo()
        {
            base.GetInfo();
        }
    }
}
