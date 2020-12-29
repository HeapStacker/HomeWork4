using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    class FilePrinter: IPrinter
    {
        private string path;
        public FilePrinter(string path)
        {
            this.path = path;
        }
        public void Print(string toPrint)
        {
            using (System.IO.StreamWriter toFile = new System.IO.StreamWriter(path))
            {
                toFile.WriteLine(toPrint);
            }
        }
    }
}


