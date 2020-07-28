using System;
using System.Collections.Generic;
using System.Text;

namespace ScannerPrinter
{
    class ScannerPrinter
    {
        private Scanner scanner;
        private Printer printer;

        public void Print()
        {
            printer.Print();
        }
        public void Scan()
        {
            scanner.Scan();
        }
    }
}
