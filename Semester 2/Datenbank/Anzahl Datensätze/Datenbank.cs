using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data.OleDb;
using System.IO;

namespace Anzahl_Datensätze
{
    public class Datenbank
    {
        static public bool legeNeuePersonAn(Person neuePerson)
        {
            return true;
        }

        static public ArrayList suchePersonen(string Alter)
        {
            ArrayList mm_liste = new ArrayList();
            string pfad =  Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string source = "Provider=Microsoft.JET.OLEDB.4.0;" + "data source='" + Path.Combine(pfad, "..\\..\\db2.mdb") + "'";
            //string source = "Provider=MySqlProv;" + "data source='cgi.rz.htw-berlin.de';" + "User id=schlingh;" + "Password=secret;";
            string command = "SELECT * FROM Person WHERE Alter " + Alter;
            //Erzeugen des Objektes...
            OleDbConnection mConnection = new OleDbConnection(source);
            //Öffnen der Datenbank
            mConnection.Open();
            //SQL-Kommando erzeugen
            OleDbCommand mCommand = new OleDbCommand(command, mConnection);

            OleDbDataReader mReader = null;
            mReader = mCommand.ExecuteReader();
            // Use Read to  read data line by line.
            while (mReader.Read())
            { //The data is extracted with the methods GetString and GetInt32
                Person mm_person = new Person();
                mm_person.Name = mReader.GetString(1);
                mm_person.Vorname = mReader.GetString(2);
                mm_person.Alter = mReader.GetInt32(3);
                //Person in Liste aufnehmen...
                mm_liste.Add(mm_person);
                //Console.WriteLine(mReader.GetInt32(0).ToString() + "-" + mReader.GetString(1) + " " + mReader.GetString(2) + " Alter:" + mReader.GetInt32(3).ToString());
            }
            // Close the Reader when done. 
            mReader.Close();
            // Close the connection when done. 
            mConnection.Close();
            return mm_liste;
        }
    }
}
