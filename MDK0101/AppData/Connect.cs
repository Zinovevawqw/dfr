using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK0101.AppData
{
    internal class Connect
    {
        public static TestEntities c;
        public static TestEntities contex
        {
            get
            { 
                if (c== null)
                    c= new TestEntities();
                return c;
            }
        }
    }
}
