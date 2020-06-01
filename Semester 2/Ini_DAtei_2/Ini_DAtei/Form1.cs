using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ini;

namespace Ini_DAtei
{
    partial class Form1 : Form
    {
        static public Inidatei neue_Datei = new Inidatei();
        static public Inidatei neu_geaenderte_Datei = new Inidatei();
        public static bool DAtei_schon_geaendert = false;
        enum status
        {
            bearbeitung = 0,
            hinzufugen = 1,

        }
        public Form1()
        {
            InitializeComponent();
            Setze_Einganseingenschaften();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            neue_Datei = new Inidatei(dateipfad_textbox.Text);
            DAtei_schon_geaendert = false;
            Alles_Eintragen();
            

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
            if (!DAtei_schon_geaendert)
            {
                Sektion ausgewaehlte_Sektion = neue_Datei.liste_von_Sektionen.ElementAt(position_ausgewaehlter_Sektion);

                Attribute selected_Attribute = ausgewaehlte_Sektion.liste_Attribute.ElementAt(position_selected_attribute);
                //wert_des_attribute_textbox.Text = selected_Attribute.wert;
                Werte_Textbox.Text = selected_Attribute.wert;
            }
            else
            {
                Sektion ausgewaehlte_Sektion = neu_geaenderte_Datei.liste_von_Sektionen.ElementAt(position_ausgewaehlter_Sektion);

                Attribute selected_Attribute = ausgewaehlte_Sektion.liste_Attribute.ElementAt(position_selected_attribute);
                //wert_des_attribute_textbox.Text = selected_Attribute.wert;
                Werte_Textbox.Text = selected_Attribute.wert;
            }

        }

        private void dateipfad_textbox_TextChanged(object sender, EventArgs e)
        {
            if (dateipfad_textbox.Text.Length > 5)
            {

                datei_Inhalt_einsehen.Enabled = true;
            }
            else
            {
                datei_Inhalt_einsehen.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datei_Inhalt_einsehen.Enabled = false;
            Button_UnEnable();
        }

        private void sektionen_ListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Button_UnEnable(true);
            Werte_Textbox.Text = String.Empty;
            int position_ausgewaehlter_Sektion = sektionen_ListBox.SelectedIndex;
            if (!DAtei_schon_geaendert && position_ausgewaehlter_Sektion >= 0)
            {
                Sektion ausgewaehlte_Sektion = neue_Datei.liste_von_Sektionen.ElementAt(position_ausgewaehlter_Sektion);
                attribute_Listbox.Items.Clear();
                foreach (Attribute attr in ausgewaehlte_Sektion.liste_Attribute)
                {
                    attribute_Listbox.Items.Add(attr.name);
                }
            }
            else if (DAtei_schon_geaendert && position_ausgewaehlter_Sektion >= 0)
            {
                Sektion ausgewaehlte_Sektion = neu_geaenderte_Datei.liste_von_Sektionen.ElementAt(position_ausgewaehlter_Sektion);
                attribute_Listbox.Items.Clear();
                foreach (Attribute attr in ausgewaehlte_Sektion.liste_Attribute)
                {
                    attribute_Listbox.Items.Add(attr.name);
                } 
            }

        }

        private void Bearbeiten_Button_Click(object sender, EventArgs e)
        {
            int selected_section = sektionen_ListBox.SelectedIndex;
            if (selected_section >= 0)
            {
                Bearbeiten_Sektion btn = new Bearbeiten_Sektion(neue_Datei.liste_von_Sektionen.ElementAt(selected_section));
                btn.ShowDialog();
                if (btn.aenderungen_vorhanden)
                {
                    if (!DAtei_schon_geaendert)
                    {
                        neu_geaenderte_Datei = neue_Datei;
                        neu_geaenderte_Datei.liste_von_Sektionen[selected_section] = btn.zu_bearbeitende_Sektion;
                        DAtei_schon_geaendert = true;
                        Alles_Eintragen();
                    }
                    else
                    {
                        neu_geaenderte_Datei.liste_von_Sektionen[selected_section] = btn.zu_bearbeitende_Sektion;
                        Alles_Eintragen();
                    }
                } 
              
            }
           
        }

        private void hinzufuegen_Button_Click(object sender, EventArgs e)
        {
            Bearbeitung_Hinzufuegen neue_Bearbeitung = new Bearbeitung_Hinzufuegen();
            neu_geaenderte_Datei = neue_Datei;
            neue_Bearbeitung.ShowDialog();
            Alles_Eintragen();
        }

        private void Loeschen_Button_Click(object sender, EventArgs e)
        {
            int selected_section_number = sektionen_ListBox.SelectedIndex;
            if (selected_section_number >= 0)
            {
                if (DAtei_schon_geaendert)
                {
                    DialogResult antwort = MessageBox.Show("Durch diese Aktion werden Sie \n die gewählte Sektion aus der Datei löschen! \n Wollen Sie wirklich trotzdem die Aktion durchführen?", "Sektion Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (antwort == DialogResult.Yes)
                    {
                        neu_geaenderte_Datei.liste_von_Sektionen.RemoveAt(selected_section_number);
                        Alles_Eintragen();

                        

                    }
                }
                else
                {
                    DialogResult antwort = MessageBox.Show("Durch diese Aktion werden Sie \n die gewählte Sektion aus der Datei löschen! \n Wollen Sie wirklich trotzdem die Aktion durchführen?", "Sektion Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (antwort == DialogResult.Yes)
                    {
                        neu_geaenderte_Datei = neue_Datei;
                        neu_geaenderte_Datei.liste_von_Sektionen.RemoveAt(selected_section_number);

                        DAtei_schon_geaendert = true;
                        Alles_Eintragen();
                     
                    }
                }

            }
        }
        private void Alles_Eintragen ()
        {
            if (DAtei_schon_geaendert)
            {
                sektionen_ListBox.Items.Clear();
                attribute_Listbox.Items.Clear();
                Werte_Textbox.Text = String.Empty;
                foreach (Sektion sektionen in neu_geaenderte_Datei.liste_von_Sektionen)
                {
                    sektionen_ListBox.Items.Add(sektionen.sektion_name);

                }
            }
            else
            {
                sektionen_ListBox.Items.Clear();
                attribute_Listbox.Items.Clear();
                Werte_Textbox.Text = String.Empty;
                foreach (Sektion sektionen in neue_Datei.liste_von_Sektionen)
                {
                    sektionen_ListBox.Items.Add(sektionen.sektion_name);

                }
            }
        }
        private void Setze_Einganseingenschaften()
        {
            openFileDialog1.DefaultExt = "ini"; // Festlegen der Standard- Dateinamenserweiterung für das Öffnen der Datei
            openFileDialog1.Filter = "Textdateien(*.ini)|*.INI|Alle Dateien(*.*)|*.*"; // Filterzeichenfolge 
            openFileDialog1.CheckFileExists = true; // Warnung, wenn der Name einer nicht vorhandenen Datei eingegeben wird.
            openFileDialog1.InitialDirectory = Application.ExecutablePath; // Festlegen des Anfangsverzeichnisses
            openFileDialog1.Title = "Öffnen Sie eine INI-datei"; // Beschriftung der Titelleiste des Dialogs
            saveFileDialog1.DefaultExt = "ini"; // Festlegen der Standard- Dateinamenserweiterung für das Speichern der Datei also der standardmäßig eingetragene Dateiname
            saveFileDialog1.AddExtension = true; // Automatisches Anhängen der Dateinamenserweiterung, falls diese vom Benutzer nicht eingegeben wurde
            saveFileDialog1.OverwritePrompt = true; // Warnung, wenn beim Speichern bereits eine gleichnamige Datei vorhanden ist
            saveFileDialog1.ValidateNames = true; // Überprüfen ob Dateiname erlaubte Zeichen enthält
            saveFileDialog1.Filter = "Textdateien (*.ini)|*.ini|Alle Dateien (*.*)|*.*";
            saveFileDialog1.InitialDirectory = Application.ExecutablePath;
            saveFileDialog1.Title = "Speichern Sie die Datei";
        }

        private void datei_durchsuchen_Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()  == DialogResult.OK)
            {
               dateipfad_textbox.Text = openFileDialog1.FileName ;
               
            }
        }

        private void speichern_Button_Click(object sender, EventArgs e)
        {
           DialogResult t =  saveFileDialog1.ShowDialog();
            if (t == DialogResult.OK)
            {
                FileStream neuesElement = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter einschreibung = new StreamWriter(neuesElement);
                if (DAtei_schon_geaendert)
                {
                    Einschreiben(neu_geaenderte_Datei.liste_von_Sektionen, einschreibung);
                }
                else
                {
                    Einschreiben(neue_Datei.liste_von_Sektionen, einschreibung);
                }
              }
        }
        void Einschreiben(List<Sektion> list_of_section, StreamWriter neuesStream)
        {
            
            for (int i = 0; i < list_of_section.Count; i++)
            {
                neuesStream.WriteLine( "[ " + list_of_section[i].sektion_name.ToString() + " ] ");
                for (int j = 0; j < list_of_section[i].liste_Attribute.Count; j++)
                {
                    if (list_of_section[i].liste_Attribute[j].wert != String.Empty)
                    {
                        neuesStream.WriteLine(list_of_section[i].liste_Attribute[j].name.ToString() + " = " + list_of_section[i].liste_Attribute[j].wert.ToString());
                    }
                    else
                    {
                        neuesStream.WriteLine(list_of_section[i].liste_Attribute[j].name.ToString() );
                    }
                        
                }
               
            }
            neuesStream.WriteLine("Ende der neuen Datei");
            neuesStream.Close();
        }
        }
    }


