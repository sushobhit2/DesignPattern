using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace TestProject
{
    class Document
    {
        public void Print()
        {
            Console.WriteLine("Inside A");
        }

        internal void Convert(IConverter converter)
        {
            var parts = new List<Part>();
            parts.Add(new Footer());
            parts.Add(new Header());

         
            foreach (var part in parts)
            {
                part.Convert(converter);
            }
        }
    }
}
