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
   public partial class Bearbeiten_Sektion : Form
    {
        public Sektion zu_bearbeitende_Sektion;
        public bool aenderungen_vorhanden = false;
        public Bearbeiten_Sektion(Sektion selektierte_Sektion)
        {
            InitializeComponent();
            this.zu_bearbeitende_Sektion = selektierte_Sektion;
            this.Text = zu_bearbeitende_Sektion.sektion_name;
            for (int i = 0; i < zu_bearbeitende_Sektion.liste_Attribute.Count; i++)
            {
                Attribute_Listbox.Items.Add(zu_bearbeitende_Sektion.liste_Attribute.ElementAt(i).name);
            }
            label5.Visible = false;
        }

        private void abbrechen_button_Click(object sender, EventArgs e)
        {
            DialogResult warnung = MessageBox.Show("Durch diese Aktion stornieren Sie alle vorherigen vorgenommenen Änderungen !! \n Wollen Sie diese Aktion trotzdem durchführen?", "Abbrechen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (warnung == DialogResult.Yes)
            {
                zu_bearbeitende_Sektion = null;
                aenderungen_vorhanden = false;
                this.Close();
            }
           
        }

        private void Attribute_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_attribute_index = Attribute_Listbox.SelectedIndex;
            if (selected_attribute_index >= 0)
            {
                Wert_Textbox.Clear();
                wert_aendern_textbox.Text = String.Empty;
                attribut_name_aendern_textbox.Text = String.Empty;
                Wert_Textbox.Text = zu_bearbeitende_Sektion.liste_Attribute.ElementAt(selected_attribute_index).wert;
                wert_aendern_textbox.Text = zu_bearbeitende_Sektion.liste_Attribute.ElementAt(selected_attribute_index).wert;
                attribut_name_aendern_textbox.Text = zu_bearbeitende_Sektion.liste_Attribute.ElementAt(selected_attribute_index).name;
            }
           
        }

        private void aenderung_vornehmen_button_Click(object sender, EventArgs e)
        {
            int selected_attribute_index = Attribute_Listbox.SelectedIndex;
            if (selected_attribute_index >= 0)
            {
                if (zu_bearbeitende_Sektion.liste_Attribute.ElementAt(selected_attribute_index).wert == wert_aendern_textbox.Text && zu_bearbeitende_Sektion.liste_Attribute.ElementAt(selected_attribute_index).name == attribut_name_aendern_textbox.Text)
                {
                   
                }
                else if(attribut_name_aendern_textbox.Text != String.Empty)
                {
                    zu_bearbeitende_Sektion.liste_Attribute.ElementAt(selected_attribute_index).wert = wert_aendern_textbox.Text;
                    zu_bearbeitende_Sektion.liste_Attribute.ElementAt(selected_attribute_index).name = attribut_name_aendern_textbox.Text;
                    Attribute_Listbox.Items.Clear();
                    Wert_Textbox.Clear();
                   for (int i = 0; i < zu_bearbeitende_Sektion.liste_Attribute.Count; i++ )
                    {
                        Attribute_Listbox.Items.Add(zu_bearbeitende_Sektion.liste_Attribute.ElementAt(i).name);
                    }
                    //label5.Visible = true;
                    //label5.Text = "Attribute erfolgreich geändert...";
                    //System.Threading.Thread.Sleep(3000);
                    //label5.Visible = false;
                    aenderungen_vorhanden = true;
                    wert_aendern_textbox.Text = String.Empty;
                    attribut_name_aendern_textbox.Text = String.Empty;

                }
                else
                {
                    MessageBox.Show("Der Name des Attributes muss angegeben werden!", "Attributename", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   attribut_name_aendern_textbox.Text = zu_bearbeitende_Sektion.liste_Attribute.ElementAt(selected_attribute_index).name ;
                }
            }
        }

        private void loeschen_Button_Click(object sender, EventArgs e)
        {
            int selected_attribute_index = Attribute_Listbox.SelectedIndex;
            if (selected_attribute_index >= 0)
            {
                zu_bearbeitende_Sektion.liste_Attribute.RemoveAt(selected_attribute_index);
                Attribute_Listbox.Items.Clear();
                Wert_Textbox.Clear();
                wert_aendern_textbox.Clear();
                attribut_name_aendern_textbox.Clear();
                for (int i = 0; i < zu_bearbeitende_Sektion.liste_Attribute.Count; i++)
                {
                    Attribute_Listbox.Items.Add(zu_bearbeitende_Sektion.liste_Attribute.ElementAt(i).name);
                }
                //label5.Visible = true;
                //label5.Text = "Löschen erfolgreich durchgeführt...";
                //System.Threading.Thread.Sleep(3000);
                //label5.Visible = false;
                aenderungen_vorhanden = true;
            }
        }

        private void alles_speichern_und_schliessen_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Sektion get_changed_section()
        {
            return this.zu_bearbeitende_Sektion;
        }

        private void attribute_hinzufuegen_button_Click(object sender, EventArgs e)
        {
            if (Attribute_Listbox.Enabled && Wert_Textbox.Enabled )
            {
                Enability(false);
                wert_label.Text = "neuer Wert";
                attribut_label.Text = "neues Attribut";
                attribute_hinzufuegen_button.Text = "Gegebenes Attribut speichern";
                wert_aendern_textbox.Text = String.Empty;
                attribut_name_aendern_textbox.Text = String.Empty;
            }
            else
            {
                
                if (attribut_name_aendern_textbox.Text == String.Empty)
                {
                    MessageBox.Show("Kein neues Attribut vorhanden.", "Attribut" ,MessageBoxButtons.OK);
                    Enability();
                }
                else
                {

                    Enability();
                    wert_label.Text = "zu ändernder Wert";
                    attribut_label.Text = "zu anderndes Attribut";
                    attribute_hinzufuegen_button.Text = "Attribute Hinzufügen";
                    Attribute neues_attribut = new Attribute(attribut_name_aendern_textbox.Text, wert_aendern_textbox.Text);
                    zu_bearbeitende_Sektion.liste_Attribute.Add(neues_attribut);
                    Attribute_Listbox.Items.Clear();
                    Wert_Textbox.Clear();
                    for (int i = 0; i < zu_bearbeitende_Sektion.liste_Attribute.Count; i++)
                    {
                        Attribute_Listbox.Items.Add(zu_bearbeitende_Sektion.liste_Attribute.ElementAt(i).name);
                    }
                    aenderungen_vorhanden = true;
                }
            }
        }
        void Enability(bool enabled = true)
        {
            Attribute_Listbox.Enabled = enabled;
            Wert_Textbox.Enabled = enabled;
            aenderung_vornehmen_button.Enabled = enabled;
            loeschen_Button.Enabled = enabled;
            alles_speichern_und_schliessen_button.Enabled = enabled;
        }
    }
}
