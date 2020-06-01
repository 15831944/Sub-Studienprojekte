using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class IconExtract
    {
        private FileInfo m_file;
        public Icon[] m_lagerIcons;
        private int m_numberOfIcons;
        private Icon[] m_smallIcons;

        public IconExtract (string File_name)
        {
            File = new FileInfo(File_name);
            IntPtr Small;
            IntPtr Large;

            if (File.Exists)
            {
                m_numberOfIcons = ExtractIconEx(File.FullName, -1, out Large, out Small, 1);

                m_lagerIcons = new Icon[m_numberOfIcons];
                m_smallIcons = new Icon[m_numberOfIcons];

                for (int index =0; index < m_numberOfIcons; index ++)
                {
                    ExtractIconEx(File.FullName, index, out Large, out Small, 1);
                    m_lagerIcons[index] = Icon.FromHandle(Large);
                    m_smallIcons[index] = Icon.FromHandle(Small);
                }
            }
         
        }
        public IconExtract()
        { }
        
        [DllImport("Shell32.dll", EntryPoint = "ExtractIconExW", CharSet = CharSet.Auto)]
        private static extern int ExtractIconEx(string sFile, int iIndex, out IntPtr piLargeVersion, out IntPtr piSmallVersion, int amountIcons);

        [DllImport("Shell32.dll", EntryPoint = "DestroyIcon", CharSet = CharSet.Auto)]
        private static extern int DestroyIcon(IntPtr _Icon);

        public Icon GetIconAt(int index, bool small = true)
        {

            if (small)
            {
                return m_smallIcons[index];            }

            else
            {
                return m_lagerIcons[index];
            }


        } 
        public FileInfo File
        {
            get
            {
                return m_file;
            }
            set
            {
                m_file = value;
            }
        }

        public int NumberOfIcons
        {
            get

            { return m_numberOfIcons; }

            set { m_numberOfIcons = value; } 
        }
    }
}
