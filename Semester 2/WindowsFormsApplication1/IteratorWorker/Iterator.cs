using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorWorker
{
    public class Iterator
    {
        protected Worker m_Worker;
        public Iterator(Worker myWorker)
        {
            this.m_Worker = myWorker;
        }
        public void Startsuche(string startverzeichnis)
        {
            m_Worker.init();
            if (string.IsNullOrEmpty(startverzeichnis)) return;
            DirectoryInfo mm_di = new DirectoryInfo(startverzeichnis);
            if (mm_di.Exists) suche(mm_di);
            m_Worker.finish();
        }

        private void suche(DirectoryInfo mm_sdir)
        {
            try
            {
                FileInfo[] mm_fis = mm_sdir.GetFiles();
                for (int i = 0; i < mm_fis.Length; ++i)
                {
                    try
                    {
                        //if (mm_fis[i].Extension == ".dll")
                        m_Worker.work(mm_fis[i]);
                    }
                    catch (Exception)
                    {
                    }
                }
                foreach (DirectoryInfo mm_di in mm_sdir.GetDirectories())
                {
                    suche(mm_di);
                }
            }
            catch (Exception)
            {
            }
        }

    }
}
