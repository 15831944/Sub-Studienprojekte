using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;


namespace MyLibTest
{
    public partial class Form1 : Form
    {
        iniHelper Newobjekt = new iniHelper();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Newobjekt.load();

           
           // Newobjekt.LoeschenSect(sect);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string sect = SectName.Text;
            string att = Att.Text;
            string value = Value.Text;

            Newobjekt.addAttibut2Sect(sect, att, value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Newobjekt.Section.Length; i++)
            {
                listBox1.Items.Add(Newobjekt.Section[i]);
            }
        }

        private void excel_open_Button_Click(object sender, EventArgs e)
        {
            Excel_Operations mm_op = new Excel_Operations();
            mm_op.Open_New_Page();
            mm_op.Blatt_ausfuellen(@"C:\Windows\winsxs\wow64_microsoft - windows - shell32_31bf3856ad364e35_6.1.7601.18429_none_d49df3775cfff119\shell32.dll");
        }

        private void btnDirselect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog mm_fbd = new FolderBrowserDialog();
            mm_fbd.SelectedPath = string.IsNullOrEmpty(tbStartFolder.Text) ? "" : tbStartFolder.Text;
            if (DialogResult.OK == mm_fbd.ShowDialog())
            {
                tbStartFolder.Text = mm_fbd.SelectedPath;
            }

        }

        private void iteratorStart_Click(object sender, EventArgs e)
        {
            IteratorWorker.Worker mm_w = new IteratorWorker.Worker();

            IteratorWorker.Iterator mm_i = new IteratorWorker.Iterator(mm_w);
            mm_i.Startsuche(tbStartFolder.Text);

        }
    }
}
