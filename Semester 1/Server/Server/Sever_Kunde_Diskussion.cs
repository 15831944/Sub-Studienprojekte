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
    public partial class Sever_Kunde_Diskussion : Form
    {
        public Sever_Kunde_Diskussion(Kunde newKunde) // Kunde mit dem der Server ins Gespräch tritt , ist übergabeparameter
        {
            InitializeComponent();
            this.Text = "Diskussion : Server - " + newKunde.Name;
            nachrichtAnKundenSendenButton.Enabled = false; // Button zum Versenden der Nachricht erstmal deaktivirien bis was auf dem Nachrichtenbox eingegeben wird.
        }

        private void nachrichtAnKundenSendenButton_Click(object sender, EventArgs e)
        {
            neueNachricht();
            
        }
         void neueNachricht ()
        {

            diskussionSeverKundenBox.Items.Add("Server : \n " + nachtrichtDesServers.Text);
            nachtrichtDesServers.Text = String.Empty;
        }
        //  wenn sich der Text des Nachrichtbox verändert, verifiziert die folgende Funktion , ob die Länge des eingegebenen Textes grösser gleich 2 ist und somit den Button aktiviert oder deaktiviert.
        private void nachtrichtDesServers_TextChanged(object sender, EventArgs e)
        {
            if (nachtrichtDesServers.Text.Length >= 2 )
            {
                nachrichtAnKundenSendenButton.Enabled = true;
            }
            else
            {
                nachrichtAnKundenSendenButton.Enabled = false;
            }
        }

        private void NachrichtLoeschenButton_Click(object sender, EventArgs e)
        {
            int ausgewaehlteNachricht = diskussionSeverKundenBox.SelectedIndex;
            if (ausgewaehlteNachricht > -1)
            {

                switch (MessageBox.Show("Wollen Sie wirklich diese Nachricht aus der Diskussion entfernen?", " Nachricht Löschen", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        diskussionSeverKundenBox.Items.RemoveAt(ausgewaehlteNachricht);
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Überlegen Sie sich noch mal länger , bevor Sie die Entscheidung treffen , eine Nachricht aus der Diskussion zu löschen", "Abgebrochene Entfernung", MessageBoxButtons.OK);
                        break;

                }
            }
        }
    }
}
