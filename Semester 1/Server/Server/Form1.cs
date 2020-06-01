using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public List<Kunde> registierteKunden   = new List<Kunde>();
        public Form1()
        {
            InitializeComponent();
            kundenverwaltungBox.Visible = false;
            // tableLayoutPanel1.Visible = true;
            this.Width = 500;
            this.Height = 190;
            //neuerKunde.Visible = false
            if (!kundenverwaltungBox.Visible)
            {
                neueenKundenEintragenToolStripMenuItem.Visible = false;
                
            }
            
        }

        private void neuerKunde_Click(object sender, EventArgs e)
        {
            Kunde newKunde;
            long newIpAdress;
            if ( nameKundebox.Text != String.Empty && ipAdressbox.Text != String.Empty && ipAdressbox.Text.Length == 12 &&  long.TryParse(ipAdressbox.Text, out newIpAdress  ))
            {
               
                if (!NameSchonVorhanden(nameKundebox.Text) && !AdresseSchonDa(newIpAdress))
                {
                    newKunde = new Kunde(nameKundebox.Text, newIpAdress);
                    registierteKunden.Add(newKunde);
                    newKunde.freundkreis.Add(newKunde);
                    kundenliste.Items.Add(nameKundebox.Text);
                    MessageBox.Show(nameKundebox.Text + " wurde erfolgreich in die Diskussion  einegtragen", "Hinzufügen eines neuen Kunden", MessageBoxButtons.OK);
                    ipAdressbox.Text = String.Empty;
                    nameKundebox.Text = String.Empty;
                    tableLayoutPanel1.Visible = false;
                    neuerKunde.Visible = false;
                    kundenverwaltungBox.Visible = true;
                    neueenKundenEintragenToolStripMenuItem.Visible = true;
                    this.Width = 500;
                    this.Height = 340;
                } 
                else if (NameSchonVorhanden(nameKundebox.Text))
                {
                    MessageBox.Show("Name leider schon benutzt. \n Suchen Sie sich einen anderen Namen aus", "vorhandener Name");
                    
                }
                else if (AdresseSchonDa(newIpAdress))
                {
                    MessageBox.Show("IP-Adresse schon registiert. \n Geben Sie eine andere ein", "Vorhandene IP Adresse");
                }
            }
            else
            {
                MessageBox.Show("Falsche Eingabe \n Versuchen es erneut", "Fehler",MessageBoxButtons.OK);
                ipAdressbox.Text = String.Empty;
                nameKundebox.Text = String.Empty;
            }

        }

        private void schliessenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            neuerKunde.Visible = false;
            kundenverwaltungBox.Visible = true;
            neueenKundenEintragenToolStripMenuItem.Visible = true;
            this.Width = 500;
            this.Height = 340;
        }

        private void neueenKundenEintragenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            neuerKunde.Visible = true;
            kundenverwaltungBox.Visible = false;
            neueenKundenEintragenToolStripMenuItem.Visible = false;
            this.Width = 500;
            this.Height = 190;
        }

        private void schliessenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool NameSchonVorhanden (string eingegebenerName)
        {
            bool name_schon_da = false;

            int i = 0;
            while (i < registierteKunden.Count /*&& registierteKunden[i].Name != eingegebenerName*/ && String.Compare(registierteKunden[i].Name,eingegebenerName,true)==1)
            {
                i++;
            }
            if ( i < registierteKunden.Count )
            {
                name_schon_da = true;
            }
            return name_schon_da;
        }
        public bool AdresseSchonDa (long eingegebeneAdresse)
        {
            bool adresse_schon_da = false;
            int i = 0;
            while (i<registierteKunden.Count&&registierteKunden[i].IPadresse != eingegebeneAdresse )
            {
                i++;
            }
            if (i<registierteKunden.Count)
            {
                adresse_schon_da = true;
            }
            return adresse_schon_da;
        }

        private void kundenEntfernen_Click(object sender, EventArgs e)
        {
            int ausgewaehlterName = kundenliste.SelectedIndex;
            if (ausgewaehlterName > -1)
            {
                
               
                switch (MessageBox.Show("Wollen Sie wirklich " + kundenliste.Items[ausgewaehlterName] + " aus der Diskussion entfernen?", "Löschen", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        kundenliste.Items.RemoveAt(ausgewaehlterName);
                        registierteKunden.RemoveAt(ausgewaehlterName);
                      /*   this.Invalidate()*/
                        break;
                      case DialogResult.No:
                        MessageBox.Show("Überlegen Sie sich noch mal länger , bevor Sie die Entscheidung treffen , einen Kunden aus der Liste zu löschen", "Abgebrochene Entfernung", MessageBoxButtons.OK);
                        break;

                }

            }
        }

        private void diskussionServerKundeAnfangen_Click(object sender, EventArgs e)
        {
            int ausgewaehlterName = kundenliste.SelectedIndex;
            if (ausgewaehlterName > -1)
            {
                Sever_Kunde_Diskussion neueDiskussion = new Sever_Kunde_Diskussion(registierteKunden.ElementAt(ausgewaehlterName));
                neueDiskussion.Show();
            }
        }
    }
}
