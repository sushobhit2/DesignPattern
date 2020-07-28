using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace TestProject
{
   public class Footer:Part
    {
        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void Convert(IConverter converter)
        {
            Console.WriteLine("Inside Footer");
            converter.Convert(this);
        }

        public override void Open()
        {
            throw new NotImplementedException();
        }
    }
}
