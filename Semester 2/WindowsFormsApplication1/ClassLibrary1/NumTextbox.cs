using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLib
{
    public class NumTextbox : System.Windows.Forms.TextBox
    {
        public int MaxAnzStellen
        {
            get;
            set;
        }


        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyValue == 65)
                {
                    e.Handled = false;
                }

                else if (e.Control && e.KeyValue == 65)
                { e.Handled = false; }

                base.OnKeyDown(e);

            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) //backspace
            {
                base.OnKeyPress(e);
            }
            else if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)) //0..9
            {

                if (this.Text.Length < MaxAnzStellen)
                {
                    base.OnKeyPress(e);
                }

                else
                {
                    e.Handled = true;
                }

            }
            else
            {
                e.Handled = true;
            }


        }

    }


}
