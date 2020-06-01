using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myOwnControl
{
    public class myTextBox : TextBox
    {
        private string alterWert=""; 

        public enum eZahlenTyp
        {
            Integer,
            IntegerPositiv,
            Double
        }

        public bool showMessageBox
        {
            get;
            set;
        }

        public eZahlenTyp ZahlenTyp
        {
            get;
            set;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            int ret;
            bool ok = false;
            
            if ((this.Text == "") ||
                ((this.Text == "-") 
                && (ZahlenTyp != eZahlenTyp.IntegerPositiv))
               )
            {
                ok = true;
            }

            switch (ZahlenTyp)
            {
                case eZahlenTyp.Integer:
                    if (int.TryParse (this.Text, out ret))
                    {
                        ok = true;
                    }
                    break;
                case eZahlenTyp.IntegerPositiv:
                    if (int.TryParse (this.Text, out ret))
                    {
                        if (ret > 0)
                        {
                            ok = true;
                        }
                    }
                    break;
                case eZahlenTyp.Double:
                    break;
            }
            
            if (ok == false)
            {
                int altePos = this.SelectionStart;

                this.Text = alterWert;
                //Cursorposition setzen!!
                if (altePos - 1 >= 0)
                {
                    this.SelectionStart = altePos - 1;
                }

                //Msgbox fehlerhafter Wert
                if (showMessageBox)
                {
                    MessageBox.Show("Fehlerhafter Wert!");
                }
            }
            else
            {
                alterWert = this.Text;
            }


            base.OnTextChanged(e);
        }

    }
}
