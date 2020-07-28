using System;
using System.Collections.Generic;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IConverter converter = new PDFConverter();
            var document = new Document();
            document.ToPDF(converter);
            
        }
    }
}
