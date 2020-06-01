using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MyLibTest
{
    public partial class IconExtract2 : Form
    {
        IconExtract test;
        public IconExtract2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
           
            if (opfd.ShowDialog() == DialogResult.OK)
            {
               tbt_Filaname.Text = opfd.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          test  = new IconExtract(tbt_Filaname.Text);
            pictureBox1.Image = test.m_lagerIcons[0].ToBitmap();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            test = new IconExtract(tbt_Filaname.Text);

            if (numericUpDown1.Value < test.NumberOfIcons)
            {
                pictureBox1.Image = test.m_lagerIcons[Convert.ToInt32(numericUpDown1.Value)].ToBitmap();
            }

            else
            {
                numericUpDown1.Value = test.NumberOfIcons -1;
              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IconExtract test = new IconExtract(tbt_Filaname.Text);
            pictureBox1.Image = test.m_lagerIcons[0].ToBitmap();
        }

        private void big_icon_CheckedChanged(object sender, EventArgs e)
        {
            IconExtract test = new IconExtract(tbt_Filaname.Text);

            if (small_icon.Checked)
            {
                pictureBox1.Image = test.GetIconAt(Convert.ToInt32(numericUpDown1.Value)).ToBitmap();
            }

            else
            {
                pictureBox1.Image = test.GetIconAt(Convert.ToInt32(numericUpDown1.Value), false).ToBitmap();
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog opfd = new SaveFileDialog();
            opfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void excel_open_Button_Click(object sender, EventArgs e)
        {
            Excel_Operations mm_op = new Excel_Operations();
            mm_op.Open_New_Page();
            mm_op.Blatt_ausfuellen(@"C:\Windows\winsxs\wow64_microsoft - windows - shell32_31bf3856ad364e35_6.1.7601.18429_none_d49df3775cfff119\shell32.dll",test.m_lagerIcons);
        }
    }
}
