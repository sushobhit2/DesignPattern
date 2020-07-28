using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
   public class Header : Part
    {
        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void Convert(IConverter converter)
        {
            Console.WriteLine("Inside Header");
            converter.Convert(this);
        }

        public override void Open()
        {
            throw new NotImplementedException();
        }
    }
}
