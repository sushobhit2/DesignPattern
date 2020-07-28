using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class Paragraph : Part
    {
        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void Convert(IConverter converter)
        {
            Console.WriteLine("Inside Paragraph");
            converter.Convert(this);
        }

        public override void Open()
        {
            throw new NotImplementedException();
        }
    }
}
