using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Abstract;
using Factory.Factory;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            NotebookFactory factory = null;
            factory = new AsusFactory("Vivibook X556",700);
            Notebook asus = factory.GetNotebook();
            asus.GetInfo();
            factory = new HPFactory("G450",900);
            Notebook hp = factory.GetNotebook();
            hp.GetInfo();
            factory = new LenovoFactory("IdeaPad Z500",500);
            Notebook lenovo = factory.GetNotebook();
            lenovo.GetInfo();
            factory = new DellFactory("Inspiron 15",1000);
            Notebook dell = factory.GetNotebook();
            dell.GetInfo();
            Console.ReadLine();
        }
    }
}
