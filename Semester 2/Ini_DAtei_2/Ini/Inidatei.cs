using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ini_DAtei
{
   public class Inidatei
    {
       public string Pfad_der_Datei;
      public string [] inhalt_der_Datei = null;
        public string rueckmeldung = null;
        public List<Sektion> liste_von_Sektionen = new List<Sektion>();
        public Inidatei (string Pfad)
        {
            this.Pfad_der_Datei = Pfad;
            Loaden();
            Sektion_Holen();

            
        }
        public Inidatei()
        {


        }


        public void Loaden()
        {
            if (File.Exists(this.Pfad_der_Datei))
            {
                FileInfo InfoDerDatei = new FileInfo(this.Pfad_der_Datei);
                if (InfoDerDatei.Extension == ".ini" || InfoDerDatei.Extension == ".INI")
                {
                    this.inhalt_der_Datei = File.ReadAllLines(this.Pfad_der_Datei);
                }
                else
                {
                    this.rueckmeldung = @" Datei nicht vom Typ /ini/ ";
                }
            }
            else
            {
                rueckmeldung = "Datei nicht gefunden";
            }
        }
        public void Sektion_Holen()
        {
            Sektion neueSektion;
            for (int j = 0; j < inhalt_der_Datei.Length; j++ )
            {
                if (inhalt_der_Datei[j] == String.Empty)
                {
                    continue;
                }
                string line = inhalt_der_Datei[j].Trim();
                
                //Section??
                if (line[0] == '[' )
                {
                    if (line[line.Length - 1] == ']')
                    {
                        string sektion_Name = line.Substring(1, line.Length - 2);
                        neueSektion = new Sektion(sektion_Name, j);
                        liste_von_Sektionen.Add(neueSektion);
                    }
                    else if (line[line.Length - 1] != ']')
                    {
                        throw new FileLoadException("Ini-Datei-Fehler : " + line);
                    }

                }
               
                else //
                {
                    if (j - 1 >= 0 && liste_von_Sektionen.Count >= 1)
                    {
                        if (line[0] != ';')
                        {
                            string nameAttribut, wertAttribut;
                            nameAttribut = "";
                            wertAttribut = "";
                            int i = 0;
                            while (i < line.Length - 1 && line[i] != '=')
                            {
                                nameAttribut += line[i];
                                i++;
                            }
                            wertAttribut = line.Substring(i + 1, line.Length - nameAttribut.Length - 1);

                            Attribute neuAttribut = new Attribute(nameAttribut, wertAttribut);
                            liste_von_Sektionen[liste_von_Sektionen.Count - 1].liste_Attribute.Add(neuAttribut);
                        }
                        else
                        {
                            if (liste_von_Sektionen[liste_von_Sektionen.Count - 1].liste_Attribute.Count != 0)
                            {
                                liste_von_Sektionen[liste_von_Sektionen.Count - 1].liste_Attribute[liste_von_Sektionen[liste_von_Sektionen.Count - 1].liste_Attribute.Count - 1].liste_von_kommentaren.Add(line.Substring(1, line.Length - 1));

                            }
                            else
                            {
                                liste_von_Sektionen[liste_von_Sektionen.Count - 1].liste_von_Kommentaren.Add(line.Substring(1, line.Length - 1));
                            }
                        }
                    }

                       
                       
                    //Kommentar

                // Attribut - zu welcher Sektion gehört es? neueSektion
                }
            }
        }

    }
}
