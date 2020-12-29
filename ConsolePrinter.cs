using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    class ConsolePrinter :IPrinter
    {
        public void Print(string toPrint)
        {
            Console.WriteLine(toPrint);
        }
    }
}
