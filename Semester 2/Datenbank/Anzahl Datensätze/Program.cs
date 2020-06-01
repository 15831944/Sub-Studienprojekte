using System;
using System.Data;
using System.Collections;

namespace Anzahl_Datensätze
{
    public class Test
    {
        public static void Main()
        {
            ArrayList suchPersonen = Datenbank.suchePersonen(">= 23");
            foreach (Person suchPerson in suchPersonen)
            {
                suchPerson.writeConsole();
            }
            Person mm_person = new Person();
            mm_person.Name = "Meier";
            mm_person.Vorname = "Susanne";
            mm_person.Alter = 43;

            Datenbank.legeNeuePersonAn(mm_person);


        }
    }

}
