// In dieser Datei sind 11 Kommentare zu erstellen, markiert 1-11
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace magischesQuadrat
{
    public partial class frmMainA : Form
    {
        /// <summary>
        /// 1
        /// </summary>
        public frmMainA()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 2
        /// </summary>
        /// <param name="sender">3 </param>
        /// <param name="e">4 </param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            ZeichneQuadrat();
        }

        /// <summary>
        /// 5
        /// </summary>
        private void ZeichneQuadrat()
        {
            // 6
            clsMagischesQuadratA mm_q1 = new clsMagischesQuadratA((uint)nudSizeMagicSquare.Value);

            // 7
            int mm_width = (int)(scMain.Panel2.Width / mm_q1.Size);
            int mm_height = (int)(scMain.Panel2.Height / mm_q1.Size);

            // 8
            int mm_maxStellen = 1 + (int)Math.Log10(mm_q1.Size * mm_q1.Size);


            Font mm_font = new Font("Verdana", (float)Math.Min(mm_width * 0.8 / mm_maxStellen, 0.8 * mm_height));
            Brush mm_brush = new SolidBrush(Color.Black);
            Graphics mm_graphics = scMain.Panel2.CreateGraphics();
            mm_graphics.Clear(BackColor);
            StringFormat mm_stringFormat = new StringFormat();
            mm_stringFormat.Alignment = StringAlignment.Center;
            mm_stringFormat.LineAlignment = StringAlignment.Center;
            SizeF mm_size = new SizeF(mm_width, mm_height);

            // 9
            for (uint mm_zeile = 0; mm_zeile < mm_q1.Size; ++mm_zeile)
            {
                // 10
                for (uint mm_spalte = 0; mm_spalte < mm_q1.Size; ++mm_spalte)
                {
                    // 11
                    mm_graphics.DrawString(
                        mm_q1.GetZahlAt(mm_zeile, mm_spalte).ToString(),
                        mm_font, mm_brush,
                        new RectangleF(
                            new PointF((int)mm_spalte * mm_width, (int)mm_zeile * mm_height), mm_size), 
                            mm_stringFormat);
                }
            }
        }

        private void nudSizeMagicSquare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// 90 Methode, die den Wert des Controls validiert und dabei ungültige manuelle Eingaben
        /// anhand der Minimum- und Maximum-Werte korrigiert 
        /// </summary>
        /// <param name="sender">91 Das diese Ereignismethode auslösende Objekt</param>
        /// <param name="e">92 zusätzliche Parameter für das aufgetretene Ereignis</param>
        private void nudSizeMagicSquare_Validating(object sender, CancelEventArgs e)
        {
            //93 Ist die eingegebene Zahl gerade?
            if (nudSizeMagicSquare.Value % 2 == 0)
            {
                //94 ... dann um 1 erniedrigen
                nudSizeMagicSquare.Value -= 1;
            }
            if (nudSizeMagicSquare.Value < nudSizeMagicSquare.Minimum)
            {
                nudSizeMagicSquare.Value = nudSizeMagicSquare.Minimum;
            }
            else if (nudSizeMagicSquare.Value > nudSizeMagicSquare.Maximum)
            {
                nudSizeMagicSquare.Value = nudSizeMagicSquare.Maximum;
            }
        }


        /// <summary>
        /// Methode wird beim Neuzeichnen-Ereignis gerufen, wenn z.B. das Formular vergößert/verkleinert
        /// wurde oder nach Verdecken neu dargestellt werden muss
        /// </summary>
        /// <param name="sender">Das diese Ereignismethode auslösende Objekt - hier immer Panel2</param>
        /// <param name="e">zusätzliche Angaben als Paint-Ereignis-Parameter</param>
        private void ScMainPanel2Paint(object sender, PaintEventArgs e)
        {
            ZeichneQuadrat();
        }
    }
}


//Von 11 möglichen Punkten wurden erreicht:
