using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Erben
{
    class basisklasse
    {
        public string Meinname;

        public basisklasse()
        {
            Meinname = "Ich bin die Basisklasse";
        }

        public void SagHallo()
        {
            MessageBox.Show(this.Meinname);    
        }
    }
}
