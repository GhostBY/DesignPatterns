using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Abstract;
using Factory.Entities;

namespace Factory.Factory
{
    public class AsusFactory : NotebookFactory
    {
        private string _model;
        private double _price;
        public AsusFactory(string model,double price)
        {
            this._model = model;
            this._price = price;
        }
        public override Notebook GetNotebook()
        {
            return new Asus(_model,_price);
        }

        
    }
}
