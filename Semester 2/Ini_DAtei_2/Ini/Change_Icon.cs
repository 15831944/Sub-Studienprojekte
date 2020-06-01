using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Ini
{
    class Change_Icon
    {
        string file_name;
        FileInfo newFile;
        public string File
        {
            get
            {
                return file_name;
            }
            set
            {
                file_name = value;
            }
        }
        int numberOfIcons;
        public int Number_Of_Icons
        {
            get
            {
                return numberOfIcons;
            }
            set
            {
                numberOfIcons = value;
            }
        }
        #region field of large und mall icons
        Icon[] List_of_largeIcons;
        Icon[] List_of_smallIcons;
        IntPtr[] small;
        IntPtr[] Large;
        #endregion


        #region Import of Fuctions for extrahing und destroying of icons
        [DllImport("shell32.dll",EntryPoint = "ExtractIconEx",CharSet =CharSet.Auto)]
         static extern int ExtractIconEx(
    string path, int i, out IntPtr[] small, out IntPtr[] big, uint op);
        [DllImport("user32.dll",EntryPoint = "DestroyIcon",  SetLastError = true)]
        static extern bool DestroyIcon(IntPtr hIcon);
        #endregion

        public Change_Icon(string fileName)
        {
            newFile = new FileInfo(fileName);
            if (newFile.Exists)
            {
                
                numberOfIcons = ExtractIconEx(fileName, -1, out small, out Large, 1);
                
                for (int i = 0; i < numberOfIcons; i++)
                {
                    List_of_largeIcons[i] = (Icon) Icon.FromHandle(Large[i]);
                    DestroyIcon(Large[i]);
                }
                for (int i = 0; i < numberOfIcons; i++)
                {
                    List_of_smallIcons[i] = (Icon) Icon.FromHandle(small[i]);
                    DestroyIcon(small[i]);
                }
            }
        }
        /// <summary>
        /// get an Icon to the one position
        /// </summary>
        /// <param name="position">position to get a icon</param>
        /// <param name="large"> tell if the icon should be Large or small</param>
        /// <returns></returns>
        public Icon get_Icon_at(int position,bool large = false)
        {
            if (position< numberOfIcons)
            {
                if (large)
                {
                    return List_of_largeIcons[position];
                }
                else
                {
                    return List_of_smallIcons[position];
                }
                
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// take an Icon to the one position and convert it to bitmap
        /// </summary>
        /// <param name="position"> position of the icon</param>
        /// <param name="large"> tell if the icon should be Large or small</param>
        /// <returns></returns>
        public Bitmap get_Bitmap_at(int position, bool large = false)
        {
            if (position<numberOfIcons)
            {
                if (large)
                {
                    return  Bitmap.FromHicon(Large[position]);
                }
                else
                {
                    return Bitmap.FromHicon(small[position]);
                }
            }
            else
            {
                return null;
            }
        }
        public void Save_Icon_To_File(Icon icon)
        {
            try
            {
                /*Bitmap newBitmap = icon.ToBitmap(); */
                //newBitmap.Save(@"C: \Users\User\Desktop\", ImageFormat.Jpeg);
            }
            catch(Exception fehler)
            {
                MessageBox.Show("Fehler", fehler.Message, MessageBoxButtons.OK);

            }
            
        }
    }
}
