using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class Earth
    {
        private static Earth instance;
        protected Earth()
        {
            
        }

        public static Earth Instance()
        {
            if (instance == null)
            {
                instance= new Earth();
            }
            return instance;
        }
}
}
