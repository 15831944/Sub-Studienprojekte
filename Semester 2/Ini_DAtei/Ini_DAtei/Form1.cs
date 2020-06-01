using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ini_DAtei
{
    public partial class Form1 : Form
    {

        Inidatei neue_Datei;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          neue_Datei  = new Inidatei(dateipfad_textbox.Text);
            foreach( Sektion sektionen in neue_Datei.liste_von_Sektionen)
            {
                sektionen_ListBox.Items.Add(sektionen.sektion_name);
            }
            if (sektionen_ListBox.Items.Count > 0)
            {
                sektionen_ListBox.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button_UnEnable();
            datei_Inhalt_einsehen.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dateipfad_textbox_TextChanged(object sender, EventArgs e)
        {
            if(dateipfad_textbox.Text.Length > 5)
            {
                
                datei_Inhalt_einsehen.Enabled = true;
            }
            else
            {
                datei_Inhalt_einsehen.Enabled = false;
            }
        }

        private void sektionen_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button_UnEnable(true);
            int position_ausgewaehlter_Sektion = sektionen_ListBox.SelectedIndex;
            Sektion ausgewaehlte_Sektion = neue_Datei.liste_von_Sektionen.ElementAt(position_ausgewaehlter_Sektion);
            attribute_Listbox.Items.Clear();
            foreach (Attribute attr in ausgewaehlte_Sektion.liste_Attribute)
            {
                attribute_Listbox.Items.Add(attr.name);
            }
        }
        void Button_UnEnable(bool Enability = false)
        {

            Loeschen_Button.Enabled = Enability;
            Bearbeiten_Button.Enabled = Enability;
            hinzufuegen_Button.Enabled = Enability;
        }

        private void attribute_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position_ausgewaehlter_Sektion = sektionen_ListBox.SelectedIndex;

            int position_selected_attribute = attribute_Listbox.SelectedIndex;
            Sektion ausgewaehlte_Sektion = neue_Datei.liste_von_Sektionen.ElementAt(position_ausgewaehlter_Sektion);

            Attribute selected_Attribute = ausgewaehlte_Sektion.liste_Attribute.ElementAt(position_selected_attribute);
            //wert_des_attribute_textbox.Text = selected_Attribute.wert;
            dateipfad_textbox.Text = "";
            dateipfad_textbox.Text = selected_Attribute.wert;

        }
    }
}
