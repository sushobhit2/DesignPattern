using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
   public interface IConverter
    {
        public void Convert(Header header);
        public void Convert(Footer footer);
        public void Convert(Paragraph paragraph);
    }
}
