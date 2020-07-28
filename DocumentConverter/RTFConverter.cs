using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    class RTFConverter : IConverter
    {
        public void Convert(Header header)
        {
            Console.WriteLine("Inside RTF connverter Header");
        }
        public void Convert(Footer footer)
        {
            Console.WriteLine("Inside RTF connverter footer");
        }
        public void Convert(Paragraph paragraph)
        {
            Console.WriteLine("Inside RTF connverter paragraph");
        }
    }
}
