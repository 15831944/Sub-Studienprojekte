using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Kunde
    {
       public long IPadresse;
        public string Name;
       public  List<Kunde> freundkreis = new List<Kunde>();
        public Kunde (string name,long IpAdresse)
        {
            this.Name = name;
            this.IPadresse = IpAdresse;
        }

    }
}
