using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorWorker
{
    public class Loescher : Worker
    {

        public override void work(FileInfo file)
        {
            Debug.Print("Ich will jetzt löschen " + file.FullName);
            //Icons holen und speichern
            //Ergebnisse in Excel speichern
        }

    }
}
