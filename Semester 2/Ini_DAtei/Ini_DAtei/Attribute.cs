using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ini_DAtei
{
    class Attribute
    {
        public string name , wert;

        public Attribute (string Name)
        {
            this.name = Name;
         
        }
       public void getValue (string value )
        {
            this.wert = value;
        }
    }
}
