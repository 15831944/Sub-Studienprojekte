using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ini_DAtei
{
  public  class Sektion
    {
       public string sektion_name;
    public List<Attribute> liste_Attribute = new List<Attribute>();
        public List<string> liste_von_Kommentaren = new List<string>();
        int zeilenummer_derSektion = 0;
        char zeilenumbruch = (char)10;
        string kommantare = "";
        
        public Sektion(string Name, int zeilenummer = -1)
        {
            this.sektion_name = Name;
            this.zeilenummer_derSektion = zeilenummer;
        }
        List<Attribute> getListAttribut()
        {
            return this.liste_Attribute;
        }
    }
}
