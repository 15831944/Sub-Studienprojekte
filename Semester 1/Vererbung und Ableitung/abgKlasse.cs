using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Erben
{
    class abgKlasse : basisklasse
    {
        int nummer;

        public abgKlasse()
        {
            nummer = 123;
            Meinname = "Ich bin die abgeleitete Klasse";
        }

        new public void SagHallo()
        {
            MessageBox.Show("AK: " + this.Meinname);
        }

    }
}
