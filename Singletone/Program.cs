using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            Earth earth1 = Earth.Instance();
            Earth earth2 = Earth.Instance();
            if (earth2 == earth1)
            {
                Console.WriteLine("Same objects");
            }
            else
            {
                Console.WriteLine("Bad work");
            }
            Console.ReadLine();
        }
    }
}
