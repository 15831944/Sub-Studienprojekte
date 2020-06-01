using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Erben
{
    class numTextBox : TextBox 
    {
        string m_vorher;

        public enum DatenFormat
        {
            Integer = 0,
            Double = 1
        }
        private DatenFormat m_EingabeTyp;
        public DatenFormat EingabeTyp
        {
            get
            {
                return m_EingabeTyp;
            }
            set
            {
                m_EingabeTyp = value;
            }
        }

        public int intValue
        {
            get
            {
                int mm_ret;
                if (int.TryParse(base.Text, out mm_ret) == false)
                {
                    mm_ret = 0;
                }
                return mm_ret;
            }
            set
            {
                Text = value.ToString();
            }
        }

        public double doubleValue
        {
            get
            {
                double mm_ret;
                if (double.TryParse(base.Text, out mm_ret) == false)
                {
                    mm_ret = 0;
                }
                return mm_ret;
            }
            set
            {
                if (m_EingabeTyp == DatenFormat.Integer)
                {
                    Text = ((int)value).ToString();
                }
                else
                {
                    Text = value.ToString();
                }
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (m_EingabeTyp == DatenFormat.Double)
            {
                int pos = base.SelectionStart;
                double mm_ret;
                if ((double.TryParse(base.Text, out mm_ret) == false)& (base.Text != ""))
                {
                    base.Text = m_vorher;
                    base.SelectionStart = pos;
                }
            }
            else
            {
                int pos = base.SelectionStart;
                int mm_ret;
                if ((int.TryParse(base.Text, out mm_ret) == false) & (base.Text != ""))
                {
                    base.Text = m_vorher;
                    base.SelectionStart = pos;
                }
            }
        }


        // Restricts the entry of characters to digits (including hex), the negative sign,
        // the decimal point, and editing keystrokes (backspace).
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            m_vorher = Text;
            base.OnKeyPress(e);

            System.Globalization.NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            string groupSeparator = numberFormatInfo.NumberGroupSeparator;
            string negativeSign = numberFormatInfo.NegativeSign;

            string keyInput = e.KeyChar.ToString();

            if (Char.IsDigit(e.KeyChar))
            {
                // Digits are OK
            }
            else if (keyInput.Equals(decimalSeparator) || keyInput.Equals(groupSeparator) ||
             keyInput.Equals(negativeSign))
            {
                // Decimal separator is OK
            }
            else if (e.KeyChar == '\b')
            {
                // Backspace key is OK
            }
            //    else if ((ModifierKeys & (Keys.Control | Keys.Alt)) != 0)
            //    {
            //     // Let the edit control handle control and alt key combinations
            //    }
            else
            {
                e.Handled = true;
            }
        }

    }
}
