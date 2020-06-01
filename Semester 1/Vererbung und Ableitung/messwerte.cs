using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Erben
{
    class messwerte
    {
        double[] m_werte = new double[100];

        public double this[int index]
        {
            get
            {
                return m_werte[index];
            }
            set
            {
                m_werte[index] = value;
            }
        }
    }
}
