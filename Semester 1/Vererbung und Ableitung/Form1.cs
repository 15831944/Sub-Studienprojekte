using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Erben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Einstellungen.Werte.Benutzername = "Werner"; 


            messwerte mm_mw = new messwerte();
            mm_mw[10] = 23.1;
            mm_mw[11] = 123.1;
            mm_mw[12] = 223.1;



            basisklasse mm_bk = new basisklasse();
            mm_bk.SagHallo();

            abgKlasse mm_ak = new abgKlasse();
            mm_ak.SagHallo();

            mm_bk = mm_ak;
            mm_bk.SagHallo();

        }

    }
}
