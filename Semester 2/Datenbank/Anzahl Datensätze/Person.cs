using System;
using System.Collections.Generic;
using System.Text;

namespace Anzahl_Datensätze
{
    public class Person
    {
        public string Name;
        public string Vorname;
        public long Alter;

        public void writeConsole()
        {
            Console.WriteLine(Vorname + " " + Name + " Alter: " + Alter);
        }
    }
}
