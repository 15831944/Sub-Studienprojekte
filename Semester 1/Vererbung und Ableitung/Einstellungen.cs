using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Erben
{
    class Einstellungen
    {
        public string Benutzername;
        public string FensterModus;
        //....

        #region singleton - Muster

        //nur ein einzelnes Objekt
        static private Einstellungen m_werte;
        public static Einstellungen Werte
        {
            get
            {
                if (m_werte == null)
                {
                    m_werte = new Einstellungen();
                }
                return m_werte;
            }
        }

        //Verhindern, daß Einstellungen-Objekte von außen erstellt werden...
        private Einstellungen() //privater Konstruktor, nicht von außen rufbar
        {
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        public void ladeEinstellungen()
        {
            //aus registry, aus xml-Datei ...
            //Benutzername ...
        }

        public void speichereEinstellungen()
        {
            //in registry, in xml-Datei ...
            //Benutzername ...

        }

    }
}
