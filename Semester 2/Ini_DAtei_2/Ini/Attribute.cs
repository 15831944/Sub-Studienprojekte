using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ini_DAtei
{
   public class Attribute
    {
        public string name , wert;
        public List<string> liste_von_kommentaren = new List<string>();

        public Attribute (string Name, string Wert)
        {
            this.name = Name;
            this.wert = Wert;
        }
    }
}
