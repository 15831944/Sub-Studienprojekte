using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace magischesQuadrat
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new frmMainA());
        }
    }
}
