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
   public partial class Bearbeitung_Hinzufuegen : Form
    {
        static List<Sektion> Liste_der_hinzugefuegten_Sektionen = new List<Sektion>();
        // int laenge_unterschied_1; // Länge der Strecke zwischen sektionBox und AttributeBox
        // int laenge_unterschied_2; // Länge der Strecke zwischen AttributeBox und WertBox
        Point position_zuruck_Button;
        Point position_abbrechen_Button;

        public Bearbeitung_Hinzufuegen()
        {
            InitializeComponent();
            // this.laenge_unterschied_1 = Math.Abs(Sektion_Textbox.Location.Y-Attribut_TextBox.Location.Y);
            // this.laenge_unterschied_2 = Math.Abs( Attribut_TextBox.Location.Y - wert_Textbox.Location.Y);
            Attribut_TextBox.Visible = false;
            wert_Textbox.Visible = false;
            this.position_zuruck_Button = zurueck_button.Location;
            this.position_abbrechen_Button = abbrechen_Button.Location;
            abbrechen_Button.Location = position_zuruck_Button;
            zurueck_button.Visible = false;
            attribut_label.Visible = false;
            Attribut_TextBox.Visible = false;
            wert_label.Visible = false;
            wert_Textbox.Visible = false;
            label1.Visible = false;
            fertig_Button.Enabled = false;
            weitere_Attribute_Button.Enabled = false;

        }

        private void abbrechen_Button_Click(object sender, EventArgs e)
        {
            if (Liste_der_hinzugefuegten_Sektionen.Count != 0)
            {
                Liste_der_hinzugefuegten_Sektionen.Clear();
            }
            this.Close();
        }

        private void weitere_Attribute_Button_Click(object sender, EventArgs e)
        {
            if (sektion_label.Visible && Sektion_Textbox.Visible)
            {
                Sektion neue_erzeugte_Sektion = new Sektion(Sektion_Textbox.Text);
                Liste_der_hinzugefuegten_Sektionen.Add(neue_erzeugte_Sektion);
                sektion_label.Visible = false;
                Sektion_Textbox.Visible = false;
                attribut_label.Visible = true;
                Attribut_TextBox.Visible = true;
                wert_label.Visible = true;
                wert_Textbox.Visible = true;
                zurueck_button.Visible = true;
                abbrechen_Button.Location = this.position_abbrechen_Button;
            }
            else
            {
                Attribute neues_Attribut = new Attribute(Attribut_TextBox.Text, wert_Textbox.Text);
                Liste_der_hinzugefuegten_Sektionen.ElementAt(Liste_der_hinzugefuegten_Sektionen.Count - 1).liste_Attribute.Add(neues_Attribut);
                Attribut_TextBox.Text = String.Empty;
                wert_Textbox.Text = String.Empty;
            }
        }

        private void Sektion_Textbox_TextChanged(object sender, EventArgs e)
        {
            if (Sektion_Textbox.Text != String.Empty && Sektion_Textbox.Text.Length > 3)
            {
                weitere_Attribute_Button.Enabled = true;
                fertig_Button.Enabled = true;
            }
            else
            {
                weitere_Attribute_Button.Enabled = false;
            }
        }

        private void Attribut_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Attribut_TextBox.Text != String.Empty)
            {
                weitere_Attribute_Button.Enabled = true;
            }
            else
            {
                weitere_Attribute_Button.Enabled = false;
            }
        }

        private void zurueck_button_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Durch diese Aktion wird die zuletzt gespeicherte Sektion mit deren Attributen gelöscht \n wollen Sie die wirklich durchführen? ", "Löschen", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                zurueck_button.Visible = false;
                attribut_label.Visible = false;
                Attribut_TextBox.Visible = false;
                wert_label.Visible = false;
                wert_Textbox.Visible = false;
                label1.Visible = false;
                fertig_Button.Enabled = false;
                weitere_Attribute_Button.Enabled = false;
                abbrechen_Button.Location = position_zuruck_Button;
                Liste_der_hinzugefuegten_Sektionen.RemoveAt(Liste_der_hinzugefuegten_Sektionen.Count - 1);
                sektion_label.Visible = true;
                Sektion_Textbox.Visible = true;

            }
            if (t == DialogResult.No)
            {

            }

        }

        private void fertig_Button_Click(object sender, EventArgs e)
        {
            if (Liste_der_hinzugefuegten_Sektionen.Count > 0)
            {
                foreach (Sektion section in Liste_der_hinzugefuegten_Sektionen)
                {
                   // Form1.neu_geaenderte_Datei.liste_von_Sektionen.Add(section);
                }
               // Form1.DAtei_schon_geaendert = true;
                Liste_der_hinzugefuegten_Sektionen.Clear();
            }

            this.Close();
        }

    }
}
