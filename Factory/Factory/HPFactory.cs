using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Abstract;
using Factory.Entities;

namespace Factory.Factory
{
    class HPFactory : NotebookFactory
    {
        private string _model;
        private double _price;
        public HPFactory(string model, double price)
        {
            this._model = model;
            this._price = price;
        }
        public override Notebook GetNotebook()
        {
            return new HP(_model, _price);
        }
    }
}
