using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    class PDFConverter : IConverter
    {
        public void Convert(Header header)
        {
            Console.WriteLine("Inside Pdf connverter Header");
        }
        public void Convert(Footer footer)
        {
            Console.WriteLine("Inside Pdf connverter footer");
        }
        public void Convert(Paragraph paragraph)
        {
            Console.WriteLine("Inside Pdf connverter paragraph");
        }
    }
}
