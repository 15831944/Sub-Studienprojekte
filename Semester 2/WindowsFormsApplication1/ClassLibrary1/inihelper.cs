using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class iniHelper
    {
        private Dictionary<string, Dictionary<string, string>> iniFileDict =
            new Dictionary<string, Dictionary<string, string>>();

#if DEBUG
        public void load(string filename = /*"H:\\xampp-control.ini"*/ @"C:\Users\User\Desktop\install.ini")
#else
        public void load(string filename)
#endif
        {
            //string[] mm_lines = File.ReadAllLines(filename);

            string curSect = "";
            StreamReader mm_sr = new StreamReader(filename, true);
            while (!mm_sr.EndOfStream)
            {
                string line = mm_sr.ReadLine().Trim();

                if (line.Length > 2 && line[0] == '[' && line[line.Length - 1] == ']')
                {
                    curSect = line.Substring(1, line.Length - 2);
                }
                else if (line.Length == 0)
                {
                    addAttibut2Sect(curSect, "", "");
                }
                else
                {
                    string att;
                    string val;
                    if (line[0] == ';')
                    {
                        att = line;
                        val = "";
                    }
                    else if (line.Contains("="))
                    {
                        int pos = line.IndexOf('=');
                        att = line.Substring(0, pos);
                        val = line.Substring(pos + 1);
                    }
                    else
                    {
                        throw (new Exception("Ini-File-Fehler!"));
                    }
                    addAttibut2Sect(curSect, att, val);
                }
                Debug.Print(line);
            }

      
        }
       public void addAttibut2Sect(string sect, string att, string val)
        {
            Dictionary<string, string> attrValueDict;
            if (!iniFileDict.ContainsKey(sect))
            {
                attrValueDict = new Dictionary<string, string>();
                iniFileDict[sect] = attrValueDict;
            }
            else
            {
                attrValueDict = iniFileDict[sect];
            }
            attrValueDict[att] = val;
        }

        public void LoeschenSect(string sect)
        {
            iniFileDict.Remove(sect);
        }

        public string[] Section
    {
            
            get { return iniFileDict.Keys.ToArray(); }

    }

        
    }
}
