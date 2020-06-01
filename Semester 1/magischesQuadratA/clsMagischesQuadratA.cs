// In dieser Datei sind 9 Kommentare zu erstellen, markiert 1-9
using System;

namespace magischesQuadrat
{
    class clsMagischesQuadratA
    {
        public const uint MaxSize = 21;
        private uint m_size;
        private uint[,] m_zahlentabelle;

        public uint Size
        {
            get
            {
                return m_size;
            }
        }


        public uint GetZahlAt(uint zeile, uint spalte)
        {
            if ((zeile < m_size) && (spalte < m_size))
            {
                return this.m_zahlentabelle[zeile, spalte];
            }
            else
            {
                throw (new ArgumentOutOfRangeException("Parameter außerhalb des Bereichs"));
            }
        }

        public clsMagischesQuadratA(uint size)
        {
            if (size % 2 == 1)
            {
                m_size = size;
            }
            else
            {
                m_size = size > 1 ? size - 1 : 1;
            }
            if (m_size > MaxSize)
            {
                m_size = MaxSize;
            }
            this.m_zahlentabelle = new uint[m_size, m_size];
            Berechnung();
        }

        /// <summary>
        /// 1
        /// </summary>
        private void Berechnung()
        {
            long mm_aktzeile = 0;
            long mm_aktspalte = 0;
            // 2
            long mm_zellen = m_size * m_size;

            // 3
            for (uint mm_i = 1; mm_i <= mm_zellen; mm_i++)
            {
                long mm_naechstezeile;
                long mm_naechstespalte;
                if (mm_i == 1)
                {
                    // 4 (was machen die nächsten beiden Zeilen)
                    mm_naechstezeile = 0;
                    mm_naechstespalte = ((this.m_size - 1) / 2);
                }
                else
                {
                    bool mm_ok = false;
                    mm_naechstezeile = mm_aktzeile - 1;
                    mm_naechstespalte = mm_aktspalte + 1;
                    // 5
                    while (false == mm_ok)
                    {
                        // 6
                        if (mm_naechstezeile < 0)
                        {
                            mm_naechstezeile = this.m_size - 1;
                        }
                        // 7
                        else if (mm_naechstespalte >= this.m_size)
                        {
                            mm_naechstespalte = 0;
                        }
                        // 8
                        else if (this.m_zahlentabelle[(mm_naechstezeile), (mm_naechstespalte)] > 0)
                        {
                            mm_naechstespalte = mm_aktspalte;
                            mm_naechstezeile = mm_aktzeile + 1;
                        }
                        else
                        {
                            mm_ok = true;
                        }
                    }
                }
                // 9
                this.m_zahlentabelle[(mm_naechstezeile), (mm_naechstespalte)] = mm_i;
                mm_aktzeile = mm_naechstezeile;
                mm_aktspalte = mm_naechstespalte;
            }
        }
    }
}

//Von 9 möglichen Punkten wurden erreicht:
